using Azure;
using Microsoft.Azure.Devices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Azure.DigitalTwins.Core;
using Microsoft.Extensions.Configuration;
using Azure.Identity;

namespace AzureDigitalTwins
{
    class DeviceOperationsApi
    {
        const string QUERY_GET_ALL_DEVICES = "SELECT * FROM devices";
        const string IOTHUB = "connectionIoTHub";

        public static async Task<List<JObject>> GetDevices()
        {
            RegistryManager rm = null;

            IConfiguration config = AuthenticationApi.GetRegistryManager();
            if (config != null)
            {
                rm = RegistryManager.CreateFromConnectionString(config[IOTHUB]);
            }

            var query = rm.CreateQuery(QUERY_GET_ALL_DEVICES);
            List<JObject> jsonDevices = new List<JObject>();

            while (query.HasMoreResults)
            {
                var devices = await query.GetNextAsJsonAsync();
                foreach (var device in devices)
                {
                    JObject json = JObject.Parse(device);
                    jsonDevices.Add(json);
                }
            }
            return jsonDevices;
        }

        public static async Task<string> GetConnectionString(string deviceId)
        {
            string connection = null;
            RegistryManager rm = null;

            IConfiguration config = AuthenticationApi.GetRegistryManager();
            if (config != null)
            {
                rm = RegistryManager.CreateFromConnectionString(config[IOTHUB]);
            }

            try
            {
                // Get device
                Device device = await rm.GetDeviceAsync(deviceId);
                string host = AuthenticationApi.GetHostDevice();

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
        const string HOST_CLIENT = "hostClient";

        public static DigitalTwinsClient GetClient()
        {
            Uri adtInstanceUrl;

            DigitalTwinsClient twinClient = null;
            IConfiguration config = AuthenticationApi.GetRegistryManager();

            if (config != null)
            {
                adtInstanceUrl = new Uri(config[HOST_CLIENT]);
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
            string namePatientTwin = await ListRelationships(client, deviceId);

            Patient patient = null;
            if (namePatientTwin != null)
            {
                patient = await GetPatientTwin(client, namePatientTwin);
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

        private async static Task<Patient> GetPatientTwin(DigitalTwinsClient client, string twinId)
        {
            List<string> IdTwins = new List<string>();

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
                FiscalCode = $"{fiscalCode}"
            };

            Debug.Log($"Reading patient finished.");
            return patient;
        }
    }
}
