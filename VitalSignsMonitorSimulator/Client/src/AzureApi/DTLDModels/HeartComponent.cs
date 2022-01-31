using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class HeartFrequencyComponent
    {

        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public HeartFrequencyComponentMetadata Metadata { get; set; } = new HeartFrequencyComponentMetadata();

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    internal class HeartFrequencyComponentMetadata
    {

        [JsonPropertyName("value")]
        public DigitalTwinPropertyMetadata Value { get; set; }

        [JsonPropertyName("alarm")]
        public DigitalTwinPropertyMetadata Alarm { get; set; }

        [JsonPropertyName("unit")]
        public DigitalTwinPropertyMetadata Unit { get; set; }
    }
}
