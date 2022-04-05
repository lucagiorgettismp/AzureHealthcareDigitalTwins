using Newtonsoft.Json;
namespace Simulator.Model.Settings
{
    public class DeviceSettings
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("temperature")]
        public SensorSettingsMinMaxThreashold<double> Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public SensorSettingsMinMaxThreashold<int> BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public SensorSettingsMinThreashold<int> Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public SensorSettingsMinMaxThreashold<int> BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public SensorSettingsMinMaxThreashold<int> HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public SensorSettingsMinThreashold<int> BatteryPower { get; set; }
    }
}