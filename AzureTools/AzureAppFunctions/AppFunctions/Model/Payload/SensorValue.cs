using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{

    public class SensorValue
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string UnitOfMeasurement { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}