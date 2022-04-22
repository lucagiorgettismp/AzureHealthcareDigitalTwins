using Newtonsoft.Json;
namespace Simulator.Model.Payload
{
    public class Sensor<T>
    {
        [JsonProperty("alert")]
        public bool Alert { get; set; }

        [JsonProperty("sensor_name")]
        public string SensorName { get; set; }

        [JsonProperty("sensor_value")]
        public SensorValue<T> SensorValue { get; set; }

        [JsonProperty("graph_color")]
        public string GraphColor { get; set; }
    }
}