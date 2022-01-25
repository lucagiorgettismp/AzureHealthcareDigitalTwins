using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Simulator
{
    class TwinOperationsApi
    {
        private const string QUERY_GET_TWINS = "SELECT * FROM digitaltwins";
        private const string MODEL_PATIENT = "dtmi:healthCareDT:Patient;1";

        public async Task<List<string>> getTwins(DigitalTwinsClient client)
        {
            List<string> IdTwins = new List<string>();

            AsyncPageable<BasicDigitalTwin> queryResult = client.QueryAsync<BasicDigitalTwin>(QUERY_GET_TWINS);

            Log.Ok("Get all DT...");
            await foreach (BasicDigitalTwin twin in queryResult)
            {
                if(twin.Metadata.ModelId == MODEL_PATIENT)
                {
                    IdTwins.Add(twin.Id);
                    Log.Ok("Digital twins: " + twin.Id);
                    Log.Ok("-----------------");
                }
            }
            Log.Ok("Reading finished.");
            Console.WriteLine();

            return IdTwins;
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
