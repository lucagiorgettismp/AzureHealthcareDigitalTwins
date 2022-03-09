using Azure;
using Azure.DigitalTwins.Core;
using Common.Utils;
using Simulator.Controller;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simulator.src.AzureApi
{
    public class TwinOperationApi
    {
        public async static void GetPatientTwin(DigitalTwinsClient client, string deviceId)
        {
            string namePatientTwin = await ListRelationships(client, deviceId);

            if(namePatientTwin != null)
            {
                await _GetPatientTwin(client, namePatientTwin);
            }
        }

        private async static Task<string> ListRelationships(DigitalTwinsClient client, string srcId)
        {
            string namePatientTwin = null;
            try
            {
                AsyncPageable<BasicRelationship> results = client.GetRelationshipsAsync<BasicRelationship>(srcId);
                Console.WriteLine($"Twin {srcId} is connected to:");

                await foreach (BasicRelationship rel in results)
                {
                    Console.WriteLine($"Twin {rel.Name} is connected to: {rel.TargetId}");
                    namePatientTwin = rel.TargetId;
                }
            }
            catch (RequestFailedException e)
            {
                Console.WriteLine($"Relationship retrieval error: {e.Status}: {e.Message}");
            }

            return namePatientTwin;
        }

        private async static Task _GetPatientTwin(DigitalTwinsClient client, string twinId)
        {
            List<string> IdTwins = new List<string>();

            Response<BasicDigitalTwin> twinResponse = await client.GetDigitalTwinAsync<BasicDigitalTwin>(twinId);

            Console.WriteLine("Get patient twin information .....");
            BasicDigitalTwin twin = twinResponse.Value;

            PatientModel patient = new PatientModel
            {
                Name = twin.Contents.TryGetValue("name", out Name),
                Surname = "",
                Age = 0,
                Gender = "",
                Height = 0,
                Weight = 0,
                Description = "",
                FiscalCode = ""
            };

            foreach (string prop in twin.Contents.Keys)
            {
                if (twin.Contents.TryGetValue(prop, out object value))
                    Console.WriteLine($"Property '{prop}': {value}");
            }

            Console.WriteLine("Reading finished.");
            Console.WriteLine();
        }
    }
}
