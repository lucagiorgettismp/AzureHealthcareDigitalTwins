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

    public class ProcessHubToDTEvents
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly string adtServiceUrl = Environment.GetEnvironmentVariable("ADT_SERVICE_URL");

        [FunctionName("ProcessHubToDTEvents")]
        public async void Run([EventGridTrigger] EventGridEvent eventGridEvent, ILogger log)
        {
            //Authenticate with Digital Twins
            var credentials = new DefaultAzureCredential();
            DigitalTwinsClient client = new DigitalTwinsClient(new Uri(adtServiceUrl), credentials, new DigitalTwinsClientOptions
            {
                Transport = new HttpClientTransport(httpClient)
            });


            log.LogInformation($"ADT service client connection created.");

            if (eventGridEvent != null && eventGridEvent.Data != null)
            {
                // Reading deviceId and temperature for IoT Hub JSON
                string data = Encoding.UTF8.GetString(eventGridEvent.Data);
                JsonSerializerSettings jsonSettings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };

                var payload = JsonConvert.DeserializeObject<EventGridMessagePayload>(data, jsonSettings);

                string deviceId = payload.SystemProperties.IothubConnectionDeviceId;

                JsonPatchDocument updateTwinData;

                switch (payload.Body.Mode) 
                {
                    case UpdateMode.Telemetry:
                        updateTwinData = BuildUpdatePatchJson((TelemetryPayloadData)payload.Body.Data);

                        break;
                    case UpdateMode.Configuration:
                        updateTwinData = new JsonPatchDocument();
                        updateTwinData.AppendReplaceRaw("/configuration", JsonConvert.SerializeObject((ConfigurationPayloadData)payload.Body.Data));

                        break;
                    case UpdateMode.DeviceId:
                        updateTwinData = new JsonPatchDocument();
                        updateTwinData.AppendReplace($"/device_id", deviceId);

                        break;
                    default:
                        throw new CrudOperationNotAvailableException();
                }

                try
                {
                    log.LogInformation($"*** {payload.Body.Mode} ***\n{updateTwinData}");
                    await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);
                }
                catch (Exception e)
                {
                    log.LogError(e.Message);
                }
            }
        }

        private JsonPatchDocument BuildUpdatePatchJson(TelemetryPayloadData data)
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
            
            if(sensor is GraphSensor)
            {
                updateTwinData.AppendReplace<string>($"/{path}/graph_color", (sensor as GraphSensor)?.GraphColor);
            }

            updateTwinData.AppendReplaceRaw($"/{path}/sensor_value", JsonConvert.SerializeObject(sensor.SensorValue));
            return updateTwinData;
        }
    }
}