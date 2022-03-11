using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{
    public class EventGridMessagePayloadBody
    {
        [JsonConstructor]
        public EventGridMessagePayloadBody(TelemetryPayloadData data, UpdateMode mode)
        {
            Mode = mode;
            Data = data;
        }

        [JsonConstructor]
        public EventGridMessagePayloadBody(ConfigurationPayloadData data, UpdateMode mode)
        {
            Mode = mode;
            Data = data;
        }

        [JsonConstructor]
        public EventGridMessagePayloadBody(DeviceIdPayloadData data, UpdateMode mode)
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