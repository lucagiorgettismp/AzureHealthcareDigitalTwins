using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{
    public class EventGridMessagePayloadBody
    {
        public EventGridMessagePayloadBody(UpdateMode mode, TelemetryPayloadData data)
        {
            Mode = mode;
            Data = data;
        }

        public EventGridMessagePayloadBody(UpdateMode mode, ConfigurationPayloadData data)
        {
            Mode = mode;
            Data = data;
        }

        public EventGridMessagePayloadBody(UpdateMode mode, DeviceIdPayloadData data)
        {
            Mode = mode;
            Data = data;
        }

        [JsonProperty("mode")]
        public UpdateMode Mode { get; set; }

        [JsonProperty("data")]
        public IEventGridMessagePayloadData Data { get; set; }
    }
}