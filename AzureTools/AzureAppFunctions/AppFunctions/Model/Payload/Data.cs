using Newtonsoft.Json; 
namespace AppFunctions.Model.Payload
{

    public class Data
    {
        [JsonProperty("temperature")]
        public Sensor Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public Sensor BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public Sensor Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public Sensor BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public Sensor HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public Sensor BatteryPower { get; set; }
    }

}