using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{
    public class EventGridMessagePayloadBody
    {
        public EventGridMessagePayloadBody(TelemetryPayloadData data)
        {
            Data = data;
        }

        public EventGridMessagePayloadBody(ConfigurationPayloadData data)
        {
            Data = data;
        }

        public EventGridMessagePayloadBody(DeviceIdPayloadData data)
        {
            Data = data;
        }

        [JsonProperty("mode")]
        public UpdateMode Mode { get; set; }

        [JsonProperty("data")]
        public IEventGridMessagePayloadData Data { get; set; }
    }
}