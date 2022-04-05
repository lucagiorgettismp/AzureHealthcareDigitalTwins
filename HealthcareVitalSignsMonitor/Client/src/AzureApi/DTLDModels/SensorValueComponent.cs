using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class SensorValueComponent
    {
        [JsonPropertyName("min_value")]
        public double MinValue { get; set; }

        [JsonPropertyName("max_value")]
        public double MaxValue { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
