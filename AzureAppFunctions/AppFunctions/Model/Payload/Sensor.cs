using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{
    public class Sensor
    {
        [JsonProperty("alert")]
        public bool Alert { get; set; }

        [JsonProperty("sensor_name")]
        public string SensorName { get; set; }

        [JsonProperty("sensor_value")]
        public SensorValue SensorValue { get; set; }
    }
}