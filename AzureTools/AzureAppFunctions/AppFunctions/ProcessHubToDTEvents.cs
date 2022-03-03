namespace AppFunctions
{
    using AppFunctions.Model.Payload;
    using Azure;
    using Azure.Core.Pipeline;
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Microsoft.Azure.EventGrid.Models;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.EventGrid;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;

    // This class processes telemetry events from IoT Hub, reads temperature of a device
    // and sets the "Temperature" property of the device with the value of the telemetry.
    public class ProcessHubToDTEvents
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly string adtServiceUrl = Environment.GetEnvironmentVariable("ADT_SERVICE_URL");

        [FunctionName("ProcessHubToDTEvents")]
        public async void Run([EventGridTrigger]EventGridEvent eventGridEvent, ILogger log)
        {
            // After this is deployed, you need to turn the Managed Identity Status to "On",
            // Grab Object Id of the function and assigned "Azure Digital Twins Owner (Preview)" role
            // to this function identity in order for this function to be authorized on ADT APIs.

            //Authenticate with Digital Twins
            var credentials = new DefaultAzureCredential();
            DigitalTwinsClient client = new DigitalTwinsClient(
                new Uri(adtServiceUrl), credentials, new DigitalTwinsClientOptions
                { Transport = new HttpClientTransport(httpClient) });
            log.LogInformation($"ADT service client connection created.");

            if (eventGridEvent != null && eventGridEvent.Data != null)
            {
                log.LogInformation(eventGridEvent.Data.ToString());

                // Reading deviceId and temperature for IoT Hub JSON
                var payload = JsonConvert.DeserializeObject<EventGridMessagePayload>(eventGridEvent.Data.ToString());
                
                string deviceId = payload.SystemProperties.IothubConnectionDeviceId;

                JsonPatchDocument updateTwinData;

                switch (payload.Body.Mode)
                {
                    case CrudMode.Create:
                        updateTwinData = BuildCraetePatchJson(payload.Body.Data);
                        await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                        break;
                    case CrudMode.Update:
                        updateTwinData = BuildUpdatePatchJson(payload.Body.Data);
                        await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                        break;
                    default:
                        throw new CrudOperationNotAvailableException();
                }

                //Update twin using device temperature

            }
        }

        
        private JsonPatchDocument BuildCraetePatchJson(Data data)
        {
            var updateTwinData = new JsonPatchDocument();

            updateTwinData.AppendAdd<double>("/temperature/value", data.Temperature.Value);
            updateTwinData.AppendAdd<bool>("/temperature/alarm", data.Temperature.Alarm);
            updateTwinData.AppendAdd<string>("/temperature/unit", data.Temperature.Unit);

            updateTwinData.AppendAdd<int>("/battery/value", data.BatteryPower.Value);
            updateTwinData.AppendAdd<bool>("/battery/alarm", data.BatteryPower.Alarm);
            updateTwinData.AppendAdd<string>("/battery/unit", data.BatteryPower.Unit);

            updateTwinData.AppendAdd<int>("/saturation/value", data.Saturation.Value);
            updateTwinData.AppendAdd<bool>("/saturation/alarm", data.Saturation.Alarm);
            updateTwinData.AppendAdd<string>("/saturation/unit", data.Saturation.Unit);

            updateTwinData.AppendAdd<int>("/heart_frequency/value", data.HeartFrequency.Value);
            updateTwinData.AppendAdd<bool>("/heart_frequency/alarm", data.HeartFrequency.Alarm);
            updateTwinData.AppendAdd<string>("/heart_frequency/unit", data.HeartFrequency.Unit);

            updateTwinData.AppendAdd<int>("/breath_frequency/value", data.BreathFrequency.Value);
            updateTwinData.AppendAdd<bool>("/breath_frequency/alarm", data.BreathFrequency.Alarm);
            updateTwinData.AppendAdd<string>("/breath_frequency/unit", data.BreathFrequency.Unit);

            updateTwinData.AppendAdd<int>("/blood_pressure/value", data.BloodPressure.Value);
            updateTwinData.AppendAdd<bool>("/blood_pressure/alarm", data.BloodPressure.Alarm);
            updateTwinData.AppendAdd<string>("/blood_pressure/unit", data.BloodPressure.Unit);

            return updateTwinData;
        }

        private JsonPatchDocument BuildUpdatePatchJson(Data data)
        {
            var updateTwinData = new JsonPatchDocument();

            updateTwinData.AppendReplace<double>("/temperature/value", data.Temperature.Value);
            updateTwinData.AppendReplace<bool>("/temperature/alarm", data.Temperature.Alarm);

            updateTwinData.AppendReplace<int>("/battery/value", data.BatteryPower.Value);
            updateTwinData.AppendReplace<bool>("/battery/alarm", data.BatteryPower.Alarm);

            updateTwinData.AppendReplace<int>("/saturation/value", data.Saturation.Value);
            updateTwinData.AppendReplace<bool>("/saturation/alarm", data.Saturation.Alarm);

            updateTwinData.AppendReplace<int>("/heart_frequency/value", data.HeartFrequency.Value);
            updateTwinData.AppendReplace<bool>("/heart_frequency/alarm", data.HeartFrequency.Alarm);

            updateTwinData.AppendReplace<int>("/breath_frequency/value", data.BreathFrequency.Value);
            updateTwinData.AppendReplace<bool>("/breath_frequency/alarm", data.BreathFrequency.Alarm);

            updateTwinData.AppendReplace<int>("/blood_pressure/value", data.BloodPressure.Value);
            updateTwinData.AppendReplace<bool>("/blood_pressure/alarm", data.BloodPressure.Alarm);

            updateTwinData.AppendReplace<int>("/configuration/last_selected_view", data.Configuration.LastSelectedView);

            return updateTwinData;
        }
    }
}