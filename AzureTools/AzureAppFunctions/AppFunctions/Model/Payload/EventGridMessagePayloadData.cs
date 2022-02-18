using Newtonsoft.Json; 
namespace AppFunctions.Model.Payload
{

    public class EventGridMessagePayloadData
    {
        [JsonProperty("temperature")]
        public Sensor Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public SensorGraph BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public SensorGraph Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public SensorGraph BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public SensorGraph HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public Sensor BatteryPower { get; set; }
    }

}