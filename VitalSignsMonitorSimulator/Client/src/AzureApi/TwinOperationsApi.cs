namespace Client.AzureApi
{
    using Azure;
    using Azure.DigitalTwins.Core;
    using AzureApi.Models;
    using Client.src.AzureApi.DTLDModels;
    using Common.Utils;
    using Microsoft.Azure.Devices;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    class TwinOperationsApi
    {
        // Query
        private const string QUERY_GET_ALL_TWINS = "SELECT * FROM digitaltwins";

        // Models name
        private const string PATIENT = "Patient";

        // Name relationship
        private const string NAME_RELATIONSHIP = "rel_has_monitor";

        // Unit of measurement
        private const string UNIT_BLOOD_PRESSURE = "mmHg";
        private const string UNIT_HEART_FREQUENCY = "bpm";
        private const string UNIT_BREATH_FREQUENCY = "rpm";
        private const string PERCENTAGE = "Percentage";
        private const string UNIT_BODY_MASS_INDEX = "Kg/m2";

        private async Task CreateDeviceHub(string deviceId)
        {
            try
            {
                var registryManager = AuthenticationApi.GetRegistryManager();
                var deviceHub = new Device(deviceId);
                await registryManager.AddDeviceAsync(deviceHub);
                Log.Ok($"Device {deviceId} created succesfully in iot hub!");
            }
            catch (RequestFailedException e)
            {
                Log.Error($"Create device error: {e.Status}: {e.Message}");
            }
            Console.WriteLine();
        }

        public async Task<List<string>> GetTwins(DigitalTwinsClient client)
        {
            List<string> IdTwins = new List<string>();

            AsyncPageable<BasicDigitalTwin> queryResult = client.QueryAsync<BasicDigitalTwin>(QUERY_GET_ALL_TWINS);

            Log.Ok("Get all DT...");
            await foreach (BasicDigitalTwin twin in queryResult)
            {
                string modelPatient = await GetModel(client, PATIENT);
                if(twin.Metadata.ModelId == modelPatient)
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

        public async Task CreatePatientTwin(
            DigitalTwinsClient client, PatientModel model)
        {
            // Create a patient twin
            var bmi = new BodyMassIndexComponent
            {
                Value = model.BodyMassIndex,
                Unit = UNIT_BODY_MASS_INDEX
            };

            string patientId = $"{model.Name}Twin";

            var patientTwin = new PatientTwin
            {
                Metadata = { ModelId = "dtmi:healthCareDT:Patient;1" },
                Name = model.Name,
                Surname = model.Surname,
                Age = model.Age,
                Gender = model.Gender,
                Description = model.Description,
                Weight = model.Weight,
                Height = model.Height,
                BodyMassIndex = bmi
            };

            Log.Ok($"Create twin with..\nName: {model.Name},\nSurname: {model.Surname}\nAge: {model.Age}\nGender: {model.Gender}" +
                $"\nDescription: {model.Description}\nWeight: {model.Weight}\nHeight: {model.Height}\nBmi: {model.BodyMassIndex}");

            try
            {
                // Create a device in iot hub
                await CreateDeviceHub($"{model.Name}VitalSignsMonitor");

                // Create patient twin
                await client.CreateOrReplaceDigitalTwinAsync(patientId, patientTwin);
                Log.Ok($"- Created twin {patientId} successfully!");

                // Create monitor twin
                string idMonitorTwin = $"{model.Name}VitalSignsMonitor";
                await CreateMonitorTwin(client, idMonitorTwin);

                // Create a relationship between patient twin and monitor twin
                await CreateRelationship(client, idMonitorTwin, patientId, NAME_RELATIONSHIP);
            }
            catch (RequestFailedException e) {
                Log.Error($"Create patient twin error: {e.Status}: {e.Message}");
            }
            Console.WriteLine();
        }

        private async Task CreateMonitorTwin(DigitalTwinsClient client, string id) {

            try
            {
                string monitorId = id;

                // Components
                var temperatureComponent = new TemperatureComponent
                {
                    Value = 0,
                    Alarm = false
                };


                var bloodPressureComponent = new BloodPressureComponent
                {
                    Value = 0,
                    Alarm = false,
                    Unit = UNIT_BLOOD_PRESSURE
                };


                var breathFrequencyComponent = new BreathFrequencyComponent
                { 
                    Value = 0,
                    Alarm = false,
                    Unit = UNIT_BREATH_FREQUENCY
                };

                var heartFrequencyComponent = new HeartFrequencyComponent
                {
                    Value = 0,
                    Alarm = false,
                    Unit = UNIT_HEART_FREQUENCY
                };

                var saturationComponent = new SaturationComponent
                {
                    Value = 0,
                    Alarm = false,
                    Unit = PERCENTAGE
                };

                var batteryComponent = new BatteryComponent
                {
                    Value = 0,
                    Alarm = false,
                    Unit = PERCENTAGE
                };

                var monitorTwin = new VitalSignsMonitor
                {
                    Metadata = { ModelId = "dtmi:healthCareDT:VitalParametersMonitor;1" },
                    Temperature = temperatureComponent,
                    BloodPressure = bloodPressureComponent,
                    Battery = batteryComponent,
                    HeartFrequency = heartFrequencyComponent,
                    BreathFrequency = breathFrequencyComponent,
                    Saturation = saturationComponent
                };

                await client.CreateOrReplaceDigitalTwinAsync(monitorId, monitorTwin);
                Log.Ok($"- Created twin {monitorId} successfully!");
            }
            catch (RequestFailedException e)
            {
                Log.Error($"Create monitor twin error: {e.Status}: {e.Message}");
            }
        }

        public async Task CreateRelationship(DigitalTwinsClient client, string srcId, string targetId, string nameRel) {

            var relationship = new BasicRelationship();
            relationship.TargetId = targetId;
            relationship.Name = nameRel;

            try
            {
                string relId = $"{srcId}-{nameRel}->{targetId}";
                await client.CreateOrReplaceRelationshipAsync(srcId, relId, relationship);
                Log.Ok($"Create relationship between {srcId} / {targetId} successfully!");
            }
            catch (RequestFailedException e)
            {
                Log.Error($"Create relationship error: {e.Status}: {e.Message}");
            }
        }

        private async Task<string> GetModel(DigitalTwinsClient client, string modelName)
        {
            AsyncPageable<DigitalTwinsModelData> modelDataList = client.GetModelsAsync();

            string modelId = null;

            await foreach (var model in modelDataList)
            {
                if (model.Id.Contains(modelName)){
                    modelId = model.Id;
                    break;
                }
            }
            return modelId;
        }
    }
}
