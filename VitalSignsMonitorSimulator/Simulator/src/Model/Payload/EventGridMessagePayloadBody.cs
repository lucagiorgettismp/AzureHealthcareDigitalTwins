namespace Simulator.Model.Payload
{
    using Common.Enums;
    using Newtonsoft.Json;

    public class EventGridMessagePayloadBody
    {
        [JsonProperty("mode")]
        public UpdateMode Mode { get; set; }

        [JsonProperty("data")]
        public EventGridMessagePayloadData Data { get; set; }
    }
}