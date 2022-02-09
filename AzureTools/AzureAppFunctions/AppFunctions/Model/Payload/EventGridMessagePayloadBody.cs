using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{

    public class EventGridMessagePayloadBody
    {
        [JsonProperty("mode")]
        public CrudMode Mode { get; set; }

        [JsonProperty("data")]
        public EventGridMessagePayloadData Data { get; set; }
    }
}