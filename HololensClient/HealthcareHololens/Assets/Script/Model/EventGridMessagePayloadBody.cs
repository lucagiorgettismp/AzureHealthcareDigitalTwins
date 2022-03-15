namespace Model
{
    using Newtonsoft.Json;

    public class EventGridMessagePayloadBody
    {
        [JsonProperty("mode")]
        public UpdateMode Mode { get; set; }

        [JsonProperty("data")]
        public ConfigurationPayloadData Data { get; set; }
    }
}