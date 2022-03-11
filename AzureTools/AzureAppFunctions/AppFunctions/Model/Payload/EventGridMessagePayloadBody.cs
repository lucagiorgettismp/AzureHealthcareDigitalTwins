using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{
    public class EventGridMessagePayloadBody
    {
        [JsonProperty("mode")]
        public UpdateMode Mode { get; set; }

        [JsonProperty("data")]
        public IEventGridMessagePayloadData Data { get; set; }
    }
}