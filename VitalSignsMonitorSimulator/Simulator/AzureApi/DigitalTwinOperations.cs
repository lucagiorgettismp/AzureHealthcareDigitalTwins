using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Simulator
{
    class DigitalTwinOperations
    {

        public async Task getModels(DigitalTwinsClient client)
        {
            AsyncPageable<DigitalTwinsModelData> modelDataList = client.GetModelsAsync();
            await foreach (var md in modelDataList)
            {
                Console.WriteLine($"- Model: {md.Id}");
            }
            Console.WriteLine();
        }

        public async Task getTwins(DigitalTwinsClient client)
        {
            string query = "SELECT * FROM digitaltwins";
            AsyncPageable<BasicDigitalTwin> queryResult = client.QueryAsync<BasicDigitalTwin>(query);

            await foreach (BasicDigitalTwin twin in queryResult)
            {
                Console.WriteLine(JsonSerializer.Serialize(twin));
                Console.WriteLine("---------------");
            }
        }

        public async Task getRelationship(DigitalTwinsClient client, string srcId) {
            try
            {
                AsyncPageable<BasicRelationship> results = client.GetRelationshipsAsync<BasicRelationship>(srcId);

                Console.WriteLine($"- Twin {srcId} is connected to:");
                await foreach (BasicRelationship rel in results)
                {
                    Console.WriteLine($" -{rel.Name}->{rel.TargetId}");
                }
            }
            catch (RequestFailedException e)
            {
                Console.WriteLine($"+ Relationship retrieval error: {e.Status}: {e.Message}");
            }
        }

        public async Task createRelationship(DigitalTwinsClient client, string srcId, string targetId, string nameRel) {

            var relationship = new BasicRelationship();
            relationship.TargetId = targetId;
            relationship.Name = nameRel;

            try
            {
                string relId = $"{srcId}-contains->{targetId}";
                await client.CreateOrReplaceRelationshipAsync(srcId, relId, relationship);
                Console.WriteLine("- Created relationship successfully");

            }
            catch (RequestFailedException e)
            {
                Console.WriteLine($"+ Create relationship error: {e.Status}: {e.Message}");
            }
        }
    }
}
