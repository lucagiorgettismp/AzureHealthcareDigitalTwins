using Newtonsoft.Json; 
namespace AppFunctions.Model.Payload
{

    public class Data
    {
        [JsonProperty("temperature")]
        public Temperature Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public BloodPressure BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public Saturation Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public BreathFrequency BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public HeartFrequency HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public BatteryPower BatteryPower { get; set; }
    }

}