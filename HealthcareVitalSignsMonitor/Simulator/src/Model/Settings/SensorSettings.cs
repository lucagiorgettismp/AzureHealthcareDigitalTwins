using Newtonsoft.Json;
namespace Simulator.Model.Settings
{
    public class SensorSettings<T>
    {
        [JsonProperty("min_value")]
        public T MinValue { get; set; }

        [JsonProperty("max_value")]
        public T MaxValue { get; set; }

        [JsonProperty("unit_of_measurement")]
        public string UnitOfMeasurement { get; set; }
    }
}