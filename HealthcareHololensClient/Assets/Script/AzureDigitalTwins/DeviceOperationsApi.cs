namespace AzureDigitalTwins
{
    using Azure;
    using System;
    using System.Threading.Tasks;
    using UnityEngine;
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Newtonsoft.Json;
    using System.Text.Json;
    using Model;
    using Assets.Script.Model;
    using static AzureDigitalTwins.AuthenticationApi;

    class TwinOperationApi
    {
        internal static DigitalTwinsClient GetClient()
        {
            Uri adtInstanceUrl;

            DigitalTwinsClient twinClient = null;
            ConnectionConfig config = GetRegistryManager();

            if (config != null)
            {
                adtInstanceUrl = new Uri(config.HostClient);
                Debug.Log("Twin client authenticating...");
                var credential = new DefaultAzureCredential();
                twinClient = new DigitalTwinsClient(adtInstanceUrl, credential);

                Debug.Log($"Service twin client created – ready to go!");
                Console.WriteLine();
            }
            return twinClient;
        }

        internal static async Task SetSelectedView(DigitalTwinsClient client, string deviceId, PanelType selectedPanel)
        {
            try
            {
                JsonPatchDocument updateTwinData = new JsonPatchDocument();
                updateTwinData.AppendReplaceRaw("/configuration", JsonConvert.SerializeObject(new ConfigurationPayloadData
                {
                    LastSelectedView = (int)selectedPanel
                }));

                await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
            }
            catch (Exception e)
            {
                Debug.LogError("SetSelected error:" + e.Message);
            }
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
        
        internal async static Task<Patient> GetPatient(DigitalTwinsClient client, string deviceId)
        {
            string patientTwinName = await ListRelationships(client, deviceId);

            Patient patient = null;
            if (patientTwinName != null)
            {
                patient = await GetPatientTwin(client, patientTwinName);
            }

            return patient;
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
