using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{

    public class Temperature
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("alarm")]
        public bool Alarm { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}