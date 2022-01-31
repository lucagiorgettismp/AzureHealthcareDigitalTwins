using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class SaturationComponent
    {

        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public SaturationComponentMetadata Metadata { get; set; } = new SaturationComponentMetadata();

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    internal class SaturationComponentMetadata
    {
        [JsonPropertyName("value")]
        public DigitalTwinPropertyMetadata Value { get; set; }

        [JsonPropertyName("alarm")]
        public DigitalTwinPropertyMetadata Alarm { get; set; }

        [JsonPropertyName("unit")]
        public DigitalTwinPropertyMetadata Unit { get; set; }
    }
}
