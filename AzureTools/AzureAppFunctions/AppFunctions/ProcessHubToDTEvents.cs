namespace AppFunctions
{
    using AppFunctions.Model.Payload;
    using Azure;
    using Azure.Core.Pipeline;
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Azure.Messaging.EventGrid;
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
                    /*
                    case CrudMode.Create:
                        updateTwinData = BuildCraetePatchJson(payload.Body.Data);
                        await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                        break;
                    */
                    case CrudMode.Update:
                        updateTwinData = BuildUpdatePatchJson(payload.Body.Data);
                        try
                        {
                            await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                        }catch(Exception e)
                        {
                            log.LogError(e.Message);
                        }
                        break;
                    default:
                        throw new CrudOperationNotAvailableException();
                }

                //Update twin using device temperature

            }
        }

        private JsonPatchDocument BuildUpdatePatchJson(EventGridMessagePayloadData data)
        {
            var updateTwinData = new JsonPatchDocument();

            updateTwinData = AppendProperties(updateTwinData, data.Temperature, "temperature");
            updateTwinData = AppendProperties(updateTwinData, data.BatteryPower, "battery");
            updateTwinData = AppendProperties(updateTwinData, data.Saturation, "saturation");
            updateTwinData = AppendProperties(updateTwinData, data.HeartFrequency, "heart_frequency");
            updateTwinData = AppendProperties(updateTwinData, data.BreathFrequency, "breath_frequency");
            updateTwinData = AppendProperties(updateTwinData, data.BloodPressure, "blood_pressure");

            return updateTwinData;
        }

        private JsonPatchDocument AppendProperties(JsonPatchDocument updateTwinData, Sensor sensor, string path)
        {
            updateTwinData.AppendReplace<string>($"/{path}/sensor_name", sensor.SensorName);
            updateTwinData.AppendReplace<bool>($"/{path}/alarm", sensor.Alarm);
            updateTwinData.AppendReplace<string>($"/{path}/graph_color", sensor.GraphColor);
            updateTwinData.AppendReplaceRaw($"/{path}/sensor_value", JsonConvert.SerializeObject(sensor.SensorValue));

            //updateTwinData = AppendValueProperties(updateTwinData, sensor.SensorValue, $"{path}/sensor_value");

            return updateTwinData;
        }

        /*
        private JsonPatchDocument AppendValueProperties(JsonPatchDocument updateTwinData, SensorValue sensorValue, string path)
        {
            updateTwinData.AppendReplace
            updateTwinData.AppendReplace<string>($"{path}/unit", sensorValue.UnitOfMeasurement);
            updateTwinData.AppendReplace<string>($"{path}/type", sensorValue.Type);
            updateTwinData.AppendReplace<string>($"{path}/symbol", sensorValue.Symbol);

            switch (sensorValue.Type)
            {
                case "int":
                    updateTwinData.AppendReplace<int>($"{path}/value", (int)sensorValue.Value);
                    break;
                case "double":
                    updateTwinData.AppendReplace<double>($"{path}/value", sensorValue.Value);
                    break;
                default:
                    throw new UnsupportedValueTypeException();
            }
            return updateTwinData;
        }
        */
    }
}