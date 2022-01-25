using Azure;
using Azure.DigitalTwins.Core;
using Simulator.Simulator.Controller;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Simulator
{
    class TwinOperationsApi
    {
        private const string QUERY_GET_TWINS = "SELECT * FROM digitaltwins";

        // TODO Sarebbe meglio scaricarli da cloud invece di hard coded
        private const string MODEL_PATIENT = "dtmi:healthCareDT:Patient;1";
        private const string MODEL_MONITOR = "dtmi:healthCareDT:VitalParametersMonitor;1";

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

        public async Task createPatientTwin(
            DigitalTwinsClient client,
            string name, 
            string surname, 
            int age,
            string gender, 
            double height,
            double weight, 
            string description,
            double bmi)
        {
            var twinData = new BasicDigitalTwin();

            twinData.Metadata.ModelId = MODEL_PATIENT;
            twinData.Contents.Add("name", name);
            twinData.Contents.Add("surname", surname);
            twinData.Contents.Add("age", age);
            twinData.Contents.Add("gender", gender);
            twinData.Contents.Add("description", description);
            twinData.Contents.Add("weight", weight);
            twinData.Contents.Add("height", height);
            twinData.Contents.Add("bmi/value", bmi);
            twinData.Id = $"{name}Twin";

            Log.Ok($"Create twin with..\nName: {name},\nSurname: {surname}\nAge: {age}\nGender: {gender}\nDescription: {description}" +
                $"\nWeight: {weight}\nHeight: {height}\nBmi: {bmi}");

            try
            {
                await client.CreateOrReplaceDigitalTwinAsync<BasicDigitalTwin>(twinData.Id, twinData);
                Log.Ok($"- Created twin {twinData.Id} successfully!");

                //createMonitorTwin()
                //create a relationship
            }
            catch (RequestFailedException e) {
                Log.Error($"Create twin error: {e.Status}: {e.Message}");
            }
            Console.WriteLine();
        }

        private async Task createMonitorTwin() {
            var twinData = new BasicDigitalTwin();
            twinData.Metadata.ModelId = MODEL_MONITOR;
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
