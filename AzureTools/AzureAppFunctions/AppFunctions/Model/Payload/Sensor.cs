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

        [JsonProperty("graph_color")]
        public (int, int, int) GraphColor { get; set; }
    }
}