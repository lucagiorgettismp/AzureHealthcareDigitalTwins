using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{

    public class Body
    {
        [JsonProperty("mode")]
        public CrudMode Mode { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}