using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{

    public class BatteryPower
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("alarm")]
        public bool Alarm { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}