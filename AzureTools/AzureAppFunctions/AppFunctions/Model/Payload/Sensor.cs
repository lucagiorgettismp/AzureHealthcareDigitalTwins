using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{

    public class Sensor
    {
        [JsonProperty("alarm")]
        public bool Alarm { get; set; }

        [JsonProperty("sensor_name")]
        public string SensorName { get; set; }

        [JsonProperty("sensor_value")]
        public SensorValue SensorValue { get; set; }

        [JsonProperty("min_value")]
        public double MinValue { get; set; }

        [JsonProperty("max_value")]
        public double MaxValue { get; set; }
    }
}