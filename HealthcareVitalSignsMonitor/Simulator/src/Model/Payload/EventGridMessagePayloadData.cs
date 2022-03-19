using Newtonsoft.Json; 
namespace Simulator.Model.Payload
{

    public class EventGridMessagePayloadData
    {
        [JsonProperty("temperature")]
        public Sensor<double> Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public Sensor<int> BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public Sensor<int> Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public Sensor<int> BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public Sensor<int> HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public Sensor<int> BatteryPower { get; set; }
    }
}