using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{
    public class GraphSensor : Sensor
    {
        [JsonProperty("graph_color")]
        public string GraphColor { get; set; }
    }
}
