using Newtonsoft.Json; 
namespace AppFunctions.Model.Payload
{

    public class Data
    {
        [JsonProperty("temperature")]
        public Temperature Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public IntDataProperty BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public IntDataProperty Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public IntDataProperty BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public IntDataProperty HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public IntDataProperty BatteryPower { get; set; }

        [JsonProperty("configuration")]
        public Configuration Configuration { get; set; }
    }

}