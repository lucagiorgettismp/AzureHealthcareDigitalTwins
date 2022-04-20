using Newtonsoft.Json;
namespace Simulator.Model.Payload
{
    public class SensorValue<T>
    {
        [JsonProperty("min_value")]
        public T MinValue { get; set; }

        [JsonProperty("max_value")]
        public T MaxValue { get; set; }

        [JsonProperty("value")]
        public T Value { get; set; }

        [JsonProperty("unit")]
        public string UnitOfMeasurement { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}