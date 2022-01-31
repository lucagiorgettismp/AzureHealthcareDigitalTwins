﻿namespace Client.AzureApi
{
    using Azure;
    using Azure.DigitalTwins.Core;
    using AzureApi.Models;
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
        private const string VITAL_PARAMETERS_MONITOR = "VitalParametersMonitor";

        // Name relationship
        private const string NAME_RELATIONSHIP = "rel_has_monitor";

        // Parameters patient twin
        private const string NAME = "name";
        private const string SURNAME = "surname";
        private const string AGE = "age";
        private const string GENDER = "gender";
        private const string DESCRIPTION = "description";
        private const string WEIGHT = "weight";
        private const string HEIGHT = "height";
        private const string BODY_MASS_INDEX = "bmi";
        private const string UNIT_BODY_MASS_INDEX = "Kg/m2";

        // Paramters vital signs monitor
        private const string TEMPERATURE = "temperature";
        private const string BATTERY = "battery";
        private const string BLOOD_PRESSURE = "blood_pressure";
        private const string HEART_FREQUENCY = "heart_frequency";
        private const string BREATH_FREQUENCY = "breath_frequency";
        private const string SATURATION = "saturation";

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
            var patientTwin = new BasicDigitalTwin();
            
            patientTwin.Metadata.ModelId = await GetModel(client, PATIENT);
            patientTwin.Contents.Add(NAME, model.Name);
            patientTwin.Contents.Add(SURNAME, model.Surname);
            patientTwin.Contents.Add(AGE, model.Age);
            patientTwin.Contents.Add(GENDER, model.Gender);
            patientTwin.Contents.Add(DESCRIPTION, model.Description);
            patientTwin.Contents.Add(WEIGHT, model.Weight);
            patientTwin.Contents.Add(HEIGHT, model.Height);

            var bmi = new BodyMassIndex();
            bmi.value = model.BodyMassIndex;
            bmi.unit = UNIT_BODY_MASS_INDEX;
            patientTwin.Contents.Add(BODY_MASS_INDEX, bmi);

            patientTwin.Id = $"{model.Name}Twin";

            Log.Ok($"Create twin with..\nName: {model.Name},\nSurname: {model.Surname}\nAge: {model.Age}\nGender: {model.Gender}" +
                $"\nDescription: {model.Description}\nWeight: {model.Weight}\nHeight: {model.Height}\nBmi: {model.BodyMassIndex}");

            try
            {
                // Create a device in iot hub
                await CreateDeviceHub($"{model.Name}VitalSignsMonitor");

                // Create patient twin
                await client.CreateOrReplaceDigitalTwinAsync<BasicDigitalTwin>(patientTwin.Id, patientTwin);
                Log.Ok($"- Created twin {patientTwin.Id} successfully!");

                // Create monitor twin
                string idMonitorTwin = $"{model.Name}VitalSignsMonitor";
                await CreateMonitorTwin(client, idMonitorTwin);

                // Create a relationship between patient twin and monitor twin
                await CreateRelationship(client, idMonitorTwin, patientTwin.Id, NAME_RELATIONSHIP);
            }
            catch (RequestFailedException e) {
                Log.Error($"Create patient twin error: {e.Status}: {e.Message}");
            }
            Console.WriteLine();
        }

        private async Task CreateMonitorTwin(DigitalTwinsClient client, string id) {

            try
            {
                var monitorTwin = new BasicDigitalTwin();

                // Component
                var temperatureComponent = new BasicDigitalTwinComponent();
                var bloodPressureComponent = new BasicDigitalTwinComponent();
                var breathFrequencyComponent = new BasicDigitalTwinComponent();
                var heartFrequencyComponent = new BasicDigitalTwinComponent();
                var saturationComponent = new BasicDigitalTwinComponent();
                var batteryComponent = new BasicDigitalTwinComponent();

                monitorTwin.Id = id;
                monitorTwin.Metadata.ModelId = await GetModel(client, VITAL_PARAMETERS_MONITOR);
                monitorTwin.Contents.Add(TEMPERATURE, temperatureComponent);
                monitorTwin.Contents.Add(BLOOD_PRESSURE, bloodPressureComponent);
                monitorTwin.Contents.Add(BATTERY, batteryComponent);
                monitorTwin.Contents.Add(HEART_FREQUENCY, heartFrequencyComponent);
                monitorTwin.Contents.Add(BREATH_FREQUENCY, breathFrequencyComponent);
                monitorTwin.Contents.Add(SATURATION, saturationComponent);

                await client.CreateOrReplaceDigitalTwinAsync<BasicDigitalTwin>(monitorTwin.Id, monitorTwin);
                Log.Ok($"- Created twin {monitorTwin.Id} successfully!");
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
