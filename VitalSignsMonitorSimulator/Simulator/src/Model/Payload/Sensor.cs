using Newtonsoft.Json;
namespace Simulator.Model.Payload
{

    public class Sensor<T>
    {
        [JsonProperty("alarm")]
        public bool Alarm { get; set; }

        [JsonProperty("sensor_name")]
        public string SensorName { get; set; }

        [JsonProperty("sensor_value")]
        public SensorValue<T> SensorValue { get; set; }
    }
}