using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class TemperatureComponent
    {

        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public TemperatureComponentMetadata Metadata { get; set; } = new TemperatureComponentMetadata();

        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }
    }

    internal class TemperatureComponentMetadata
    {

        [JsonPropertyName("value")]
        public DigitalTwinPropertyMetadata Value { get; set; }

        [JsonPropertyName("alarm")]
        public DigitalTwinPropertyMetadata Alarm { get; set; }
    }
}
