﻿using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.Api.DTLDModels
{
    class VitalSignsMonitor
    {
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public VitalSignsMonitorMetadata Metadata { get; set; } = new VitalSignsMonitorMetadata();

        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        [JsonPropertyName("configuration")]
        public Configuration Configuration { get; set; }

        [JsonPropertyName("temperature")]
        public SensorComponent Temperature { get; set; }

        [JsonPropertyName("blood_pressure")]
        public GraphSensorComponent BloodPressure { get; set; }

        [JsonPropertyName("battery")]
        public SensorComponent Battery { get; set; }

        [JsonPropertyName("heart_frequency")]
        public GraphSensorComponent HeartFrequency { get; set; }

        [JsonPropertyName("breath_frequency")]
        public GraphSensorComponent BreathFrequency { get; set; }

        [JsonPropertyName("saturation")]
        public GraphSensorComponent Saturation { get; set; }
    }
    internal class VitalSignsMonitorMetadata
    {
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.MetadataModel)]
        public string ModelId { get; set; }

        [JsonPropertyName("device_id")]
        public DigitalTwinPropertyMetadata DeviceId { get; set; }

        [JsonPropertyName("configuration")]
        public DigitalTwinPropertyMetadata Configuration { get; set; }

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
