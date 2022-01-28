using Newtonsoft.Json; 
using System;
namespace AppFunctions.Model.Payload
{

    public class SystemProperties
    {
        [JsonProperty("iothub-content-type")]
        public string IothubContentType { get; set; }

        [JsonProperty("iothub-content-encoding")]
        public string IothubContentEncoding { get; set; }

        [JsonProperty("iothub-connection-device-id")]
        public string IothubConnectionDeviceId { get; set; }

        [JsonProperty("iothub-connection-auth-method")]
        public string IothubConnectionAuthMethod { get; set; }

        [JsonProperty("iothub-connection-auth-generation-id")]
        public string IothubConnectionAuthGenerationId { get; set; }

        [JsonProperty("iothub-enqueuedtime")]
        public DateTime IothubEnqueuedtime { get; set; }

        [JsonProperty("iothub-message-source")]
        public string IothubMessageSource { get; set; }
    }
}