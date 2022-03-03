using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class SensorComponent
    {

        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public SensorComponentMetadata Metadata { get; set; } = new SensorComponentMetadata();

        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }

        [JsonPropertyName("sensor_name")]
        public string SensorName { get; set; }

        [JsonPropertyName("sensor_value")]
        public SensorValueComponent SensorValue { get; set; }
    }

    internal class SensorComponentMetadata
    {
        [JsonPropertyName("alarm")]
        public DigitalTwinPropertyMetadata Alarm { get; set; }

        [JsonPropertyName("sensor_name")]
        public DigitalTwinPropertyMetadata SensorName { get; set; }

        [JsonPropertyName("sensor_value")]
        public DigitalTwinPropertyMetadata SensorValue { get; set; }
    }
}
