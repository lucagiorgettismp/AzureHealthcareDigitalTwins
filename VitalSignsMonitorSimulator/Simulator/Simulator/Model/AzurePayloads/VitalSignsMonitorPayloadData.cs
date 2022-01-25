namespace Simulator.Simulator.Model
{
    using Newtonsoft.Json;

    class VitalSignsMonitorPayloadData
    {
        [JsonProperty("temperature")]
        public VitalSignsMonitorPayloadParameter Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public VitalSignsMonitorPayloadParameter BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public VitalSignsMonitorPayloadParameter Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public VitalSignsMonitorPayloadParameter BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public VitalSignsMonitorPayloadParameter HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public VitalSignsMonitorPayloadParameter BatteryPower { get; set; }
    }
}
