using Newtonsoft.Json;
namespace Simulator.Model.Payload
{

    public class SensorValue<T>
    {
        [JsonProperty("value")]
        public T Value { get; set; }

        [JsonProperty("unit")]
        public string UnitOfMeasurement { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}