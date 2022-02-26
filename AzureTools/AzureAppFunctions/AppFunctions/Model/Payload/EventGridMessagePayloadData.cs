using Newtonsoft.Json; 
namespace AppFunctions.Model.Payload
{

    public class EventGridMessagePayloadData
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("temperature")]
        public Sensor Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public GraphSensor BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public GraphSensor Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public GraphSensor BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public GraphSensor HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public Sensor BatteryPower { get; set; }
    }

}