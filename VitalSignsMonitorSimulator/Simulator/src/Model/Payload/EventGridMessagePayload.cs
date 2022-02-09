using Newtonsoft.Json;
namespace Simulator.Model.Payload
{

    public class EventGridMessagePayload
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("systemProperties")]
        public SystemProperties SystemProperties { get; set; }

        [JsonProperty("body")]
        public EventGridMessagePayloadBody Body { get; set; }
    }
}