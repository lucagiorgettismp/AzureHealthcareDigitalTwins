using Azure;
using Microsoft.Azure.Devices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Azure.DigitalTwins.Core;
using Microsoft.Extensions.Configuration;
using Azure.Identity;
using static AzureDigitalTwins.AuthenticationApi;
using Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace AzureDigitalTwins
{
    class DeviceOperationsApi
    {
        public static async Task<string> GetConnectionString(string deviceId)
        {
            string connection = null;
            string host = null;
            RegistryManager rm = null;

            ConnectionConfig config = AuthenticationApi.GetRegistryManager();
            if (config != null)
            {
                rm = RegistryManager.CreateFromConnectionString(config.connectionIoTHub);
                host = config.hostIotHub;
            }

            try
            {
                // Get device
                Device device = await rm.GetDeviceAsync(deviceId);

                // Get string connection
                connection = $"HostName={host};DeviceId={device.Id};SharedAccessKey={device.Authentication.SymmetricKey.PrimaryKey}";
            }
            catch (RequestFailedException)
            {
            }
            Console.WriteLine();

            return connection;
        }
    }

    class TwinOperationApi
    {
        public static DigitalTwinsClient GetClient()
        {
            Uri adtInstanceUrl;

            DigitalTwinsClient twinClient = null;
            ConnectionConfig config = AuthenticationApi.GetRegistryManager();

            if (config != null)
            {
                adtInstanceUrl = new Uri(config.hostClient);
                Debug.Log("Twin client authenticating...");
                var credential = new DefaultAzureCredential();
                twinClient = new DigitalTwinsClient(adtInstanceUrl, credential);

                Debug.Log($"Service twin client created – ready to go!");
                Console.WriteLine();
            }
            return twinClient;
        }

        public async static Task<Patient> GetPatient(DigitalTwinsClient client, string deviceId)
        {
            string patientTwinName = await ListRelationships(client, deviceId);

            Patient patient = null;
            if (patientTwinName != null)
            {
                patient = await GetPatientTwin(client, patientTwinName);
            }

            return patient;
        }

        private async static Task<string> ListRelationships(DigitalTwinsClient client, string srcId)
        {
            string namePatientTwin = null;
            try
            {
                AsyncPageable<BasicRelationship> results = client.GetRelationshipsAsync<BasicRelationship>(srcId);
                Debug.Log($"Twin {srcId} is connected to:");

                await foreach (BasicRelationship rel in results)
                {
                    Debug.Log($"Twin {rel.Name} is connected to: {rel.TargetId}");
                    namePatientTwin = rel.TargetId;
                }
            }
            catch (RequestFailedException e)
            {
                Debug.LogError($"Relationship retrieval error: {e.Status}: {e.Message}");
            }

            return namePatientTwin;
        }

        internal static async Task<PanelType> GetSelectedView(DigitalTwinsClient client, string deviceId)
        {
            Response<BasicDigitalTwin> twinResponse = await client.GetDigitalTwinAsync<BasicDigitalTwin>(deviceId);

            Debug.Log("Getting selected panel ...");
            BasicDigitalTwin twin = twinResponse.Value;

            twin.Contents.TryGetValue("configuration", out object configuration);

            var configurationJson = configuration.ToString();
            var conf = JsonConvert.DeserializeObject<ConfigurationPayloadData>(configurationJson);

            return (PanelType)conf.LastSelectedView;
        }

        private async static Task<Patient> GetPatientTwin(DigitalTwinsClient client, string twinId)
        {
            Response<BasicDigitalTwin> twinResponse = await client.GetDigitalTwinAsync<BasicDigitalTwin>(twinId);

            Debug.Log("Get patient twin information .....");
            BasicDigitalTwin twin = twinResponse.Value;

            twin.Contents.TryGetValue("name", out object name);
            twin.Contents.TryGetValue("surname", out object surname);
            twin.Contents.TryGetValue("age", out object age);
            twin.Contents.TryGetValue("gender", out object gender);
            twin.Contents.TryGetValue("height", out object height);
            twin.Contents.TryGetValue("weight", out object weight);
            twin.Contents.TryGetValue("description", out object description);
            twin.Contents.TryGetValue("fiscal_code", out object fiscalCode);
            twin.Contents.TryGetValue("bmi", out object bmiValue);

            var bmiJson = bmiValue.ToString();
            var bmi = JsonConvert.DeserializeObject<BmiPayloadData>(bmiJson);

            Debug.Log("Creating patient model....");
            Patient patient = new Patient
            {
                Name = $"{name}",
                Surname = $"{surname}",
                Age = Convert.ToInt32($"{age}"),
                Gender = $"{gender}",
                Height = Convert.ToDouble($"{height}"),
                Weight = Convert.ToDouble($"{weight}"),
                Description = $"{description}",
                FiscalCode = $"{fiscalCode}",
                BodyMassIndex = $"{Math.Round(bmi.Value, 2)} {bmi.Unit}"           
            };

            Debug.Log($"Reading patient finished.");
            return patient;
        }

        [Serializable]
        private class BmiPayloadData
        {
            [JsonProperty("value")]
            public double Value { get; set; }

            [JsonProperty("unit")]
            public string Unit { get; set; }
        }
    }
}
