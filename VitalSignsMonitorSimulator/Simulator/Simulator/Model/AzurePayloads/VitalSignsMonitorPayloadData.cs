namespace Simulator.Simulator.Model
{
    using Newtonsoft.Json;

    class VitalSignsMonitorPayloadData
    {
        [JsonProperty("temperature")]
        public VitalSignsMonitorPayloadParameter<double> Temperature { get; set; }

        [JsonProperty("blood_pressure")]
        public VitalSignsMonitorPayloadParameter<int> BloodPressure { get; set; }

        [JsonProperty("saturation")]
        public VitalSignsMonitorPayloadParameter<int> Saturation { get; set; }

        [JsonProperty("breath_frequency")]
        public VitalSignsMonitorPayloadParameter<int> BreathFrequency { get; set; }

        [JsonProperty("heart_frequency")]
        public VitalSignsMonitorPayloadParameter<int> HeartFrequency { get; set; }

        [JsonProperty("battery_power")]
        public VitalSignsMonitorPayloadParameter<int> BatteryPower { get; set; }
    }
}
