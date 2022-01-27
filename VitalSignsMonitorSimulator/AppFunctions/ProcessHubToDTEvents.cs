namespace AppFunctions
{
    using Azure;
    using Azure.Core.Pipeline;
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Azure.Messaging.EventGrid;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.EventGrid;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
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
                JObject deviceMessage = (JObject)JsonConvert.DeserializeObject(eventGridEvent.Data.ToString());
                string deviceId = (string)deviceMessage["systemProperties"]["iothub-connection-device-id"];
                
                var temperature = deviceMessage["body"]["temperature"];
                var bloodPressure = deviceMessage["body"]["bloodPressure"];
                var saturation = deviceMessage["body"]["saturation"];
                var breathFrequency = deviceMessage["body"]["breathFrequency"];
                var heartFrequency = deviceMessage["body"]["heartFrequency"];
                var batteryPower = deviceMessage["body"]["batteryPower"];

                log.LogInformation($"Device:{deviceId} Temperature is:{temperature.Value<double>()}");
                log.LogInformation($"Device:{deviceId} BloodPressure is:{bloodPressure.Value<int>()}");
                log.LogInformation($"Device:{deviceId} Saturation is:{saturation.Value<int>()}");
                log.LogInformation($"Device:{deviceId} BreathFrequency is:{breathFrequency.Value<int>()}");
                log.LogInformation($"Device:{deviceId} HeartFrequency is:{heartFrequency.Value<int>()}");
                log.LogInformation($"Device:{deviceId} BatteryPower is:{batteryPower.Value<int>()}");

                log.LogInformation("Terminata fase di lettura dei dati");

                //Update twin using device temperature
                var updateTwinData = new JsonPatchDocument();
                updateTwinData.AppendReplace("/temperature/value", temperature.Value<double>());
                updateTwinData.AppendReplace("/battery/value", batteryPower.Value<int>());
                updateTwinData.AppendReplace("/saturation/value", saturation.Value<int>());
                updateTwinData.AppendReplace("/blood_pressure/value", bloodPressure.Value<int>());
                updateTwinData.AppendReplace("/breath_frequency/value", breathFrequency.Value<int>());
                updateTwinData.AppendReplace("/heart_frequency/value", heartFrequency.Value<int>());

                await client.UpdateDigitalTwinAsync(deviceId, updateTwinData);

                log.LogInformation("ADT updated.");
            }
        }
    }
}