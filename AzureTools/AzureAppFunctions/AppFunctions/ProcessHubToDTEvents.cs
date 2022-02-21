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
    using System.Text;

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
                string data = Encoding.UTF8.GetString(eventGridEvent.Data);
                log.LogInformation($"UTF8: {Encoding.UTF8.GetString(eventGridEvent.Data)}");
                log.LogInformation($"\n\nUTF16: {Encoding.Unicode.GetString(eventGridEvent.Data)}");
                log.LogInformation($"ASCII: {Encoding.ASCII.GetString(eventGridEvent.Data)}");

                var payload = JsonConvert.DeserializeObject<EventGridMessagePayload>(data);
                
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
            }
        }

        private JsonPatchDocument BuildUpdatePatchJson(EventGridMessagePayloadData data)
        {
            var updateTwinData = new JsonPatchDocument();

            updateTwinData = AppendProperties(updateTwinData, data.Temperature, "temperature");
            updateTwinData = AppendProperties(updateTwinData, data.BatteryPower, "battery");
            updateTwinData = AppendPropertiesGraph(updateTwinData, data.Saturation, "saturation");
            updateTwinData = AppendPropertiesGraph(updateTwinData, data.HeartFrequency, "heart_frequency");
            updateTwinData = AppendPropertiesGraph(updateTwinData, data.BreathFrequency, "breath_frequency");
            updateTwinData = AppendPropertiesGraph(updateTwinData, data.BloodPressure, "blood_pressure");

            return updateTwinData;
        }

        private JsonPatchDocument AppendProperties(JsonPatchDocument updateTwinData, Sensor sensor, string path)
        {
            updateTwinData.AppendReplace<string>($"/{path}/sensor_name", sensor.SensorName);
            updateTwinData.AppendReplace<bool>($"/{path}/alarm", sensor.Alarm);
            updateTwinData.AppendReplaceRaw($"/{path}/sensor_value", JsonConvert.SerializeObject(sensor.SensorValue));
            return updateTwinData;
        }

        private JsonPatchDocument AppendPropertiesGraph(JsonPatchDocument updateTwinData, SensorGraph sensor, string path)
        {
            updateTwinData.AppendReplace<string>($"/{path}/sensor_name", sensor.SensorName);
            updateTwinData.AppendReplace<bool>($"/{path}/alarm", sensor.Alarm);
            updateTwinData.AppendReplace<string>($"/{path}/graph_color", sensor.GraphColor);
            updateTwinData.AppendReplaceRaw($"/{path}/sensor_value", JsonConvert.SerializeObject(sensor.SensorValue));
            return updateTwinData;
        }
    }
}