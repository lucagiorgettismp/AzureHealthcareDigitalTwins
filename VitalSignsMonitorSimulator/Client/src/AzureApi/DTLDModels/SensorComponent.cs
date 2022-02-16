﻿using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class SensorComponent
    {

        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public TemperatureComponentMetadata Metadata { get; set; } = new TemperatureComponentMetadata();

        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }

        [JsonPropertyName("sensor_name")]
        public string SensorName { get; set; }


        [JsonPropertyName("sensor_value")]
        public SensorValueComponent SensorValue { get; set; }

        [JsonPropertyName("min_value")]
        public double MinValue { get; set; }

        [JsonPropertyName("max_value")]
        public double MaxValue { get; set; }
    }

    internal class TemperatureComponentMetadata
    {
        [JsonPropertyName("alarm")]
        public DigitalTwinPropertyMetadata Alarm { get; set; }

        [JsonPropertyName("sensor_name")]
        public DigitalTwinPropertyMetadata SensorName { get; set; }

        [JsonPropertyName("sensor_value")]
        public DigitalTwinPropertyMetadata SensorValue { get; set; }

        [JsonPropertyName("min_value")]
        public DigitalTwinPropertyMetadata MinValue { get; set; }

        [JsonPropertyName("max_value")]
        public DigitalTwinPropertyMetadata MaxValue { get; set; }
    }
}
