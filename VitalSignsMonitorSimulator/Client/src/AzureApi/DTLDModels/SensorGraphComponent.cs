using System.Text.Json.Serialization;
using Azure.DigitalTwins.Core;

namespace Client.src.AzureApi.DTLDModels
{
    class SensorGraphComponent
    {

        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public SensorGraphComponentMetadata Metadata { get; set; } = new SensorGraphComponentMetadata();

        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }

        [JsonPropertyName("sensor_name")]
        public string SensorName { get; set; }

        [JsonPropertyName("sensor_value")]
        public SensorValueComponent SensorValue { get; set; }

        [JsonPropertyName("graph_color")]
        public string GraphColor { get; set; }
    }

    internal class SensorGraphComponentMetadata
    {
        [JsonPropertyName("alarm")]
        public DigitalTwinPropertyMetadata Alarm { get; set; }

        [JsonPropertyName("sensor_name")]
        public DigitalTwinPropertyMetadata SensorName { get; set; }

        [JsonPropertyName("sensor_value")]
        public DigitalTwinPropertyMetadata SensorValue { get; set; }

        [JsonPropertyName("graph_color")]
        public DigitalTwinPropertyMetadata GraphColor { get; set; }
    }
}
