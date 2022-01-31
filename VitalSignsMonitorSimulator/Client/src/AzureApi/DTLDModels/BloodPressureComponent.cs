using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class BloodPressureComponent
    {

        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public BloodPressureComponentMetadata Metadata { get; set; } = new BloodPressureComponentMetadata();

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    internal class BloodPressureComponentMetadata
    {

        [JsonPropertyName("value")]
        public DigitalTwinPropertyMetadata Value { get; set; }

        [JsonPropertyName("alarm")]
        public DigitalTwinPropertyMetadata Alarm { get; set; }

        [JsonPropertyName("unit")]
        public DigitalTwinPropertyMetadata Unit { get; set; }
    }
}
