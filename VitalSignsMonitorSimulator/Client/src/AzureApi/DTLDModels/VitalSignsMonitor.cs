using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client.src.AzureApi.DTLDModels
{
    class VitalSignsMonitor
    {
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public VitalSignsMonitorMetadata Metadata { get; set; } = new VitalSignsMonitorMetadata();

        [JsonPropertyName("temperature")]
        public SensorComponent Temperature { get; set; }

        [JsonPropertyName("blood_pressure")]
        public SensorGraphComponent BloodPressure { get; set; }

        [JsonPropertyName("battery")]
        public SensorComponent Battery { get; set; }

        [JsonPropertyName("heart_frequency")]
        public SensorGraphComponent HeartFrequency { get; set; }

        [JsonPropertyName("breath_frequency")]
        public SensorGraphComponent BreathFrequency { get; set; }

        [JsonPropertyName("saturation")]
        public SensorGraphComponent Saturation { get; set; }
    }
    internal class VitalSignsMonitorMetadata
    {
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.MetadataModel)]
        public string ModelId { get; set; }

        [JsonPropertyName("temperature")]
        public DigitalTwinPropertyMetadata Temperature { get; set; }

        [JsonPropertyName("blood_pressure")]
        public DigitalTwinPropertyMetadata BloodPressure { get; set; }

        [JsonPropertyName("battery")]
        public DigitalTwinPropertyMetadata Battery { get; set; }

        [JsonPropertyName("heart_frequency")]
        public DigitalTwinPropertyMetadata HeartFrequency { get; set; }

        [JsonPropertyName("breath_frequency")]
        public DigitalTwinPropertyMetadata BreathFrequency { get; set; }

        [JsonPropertyName("saturation")]
        public DigitalTwinPropertyMetadata Saturation { get; set; }
    }
}
