using Azure.DigitalTwins.Core;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    class PatientTwin
    {
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public PatientTwinMetadata Metadata { get; set; } = new PatientTwinMetadata();

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("weight")]
        public double Weight { get; set; }

        [JsonPropertyName("height")]
        public double Height { get; set; }

        [JsonPropertyName("bmi")]
        public BodyMassIndexComponent BodyMassIndex { get; set; }
    }

    internal class PatientTwinMetadata
    {
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.MetadataModel)]
        public string ModelId { get; set; }

        [JsonPropertyName("name")]
        public DigitalTwinPropertyMetadata Name { get; set; }

        [JsonPropertyName("surname")]
        public DigitalTwinPropertyMetadata Surname { get; set; }

        [JsonPropertyName("age")]
        public DigitalTwinPropertyMetadata Age { get; set; }

        [JsonPropertyName("gender")]
        public DigitalTwinPropertyMetadata Gender { get; set; }

        [JsonPropertyName("description")]
        public DigitalTwinPropertyMetadata Description { get; set; }

        [JsonPropertyName("weight")]
        public DigitalTwinPropertyMetadata Weight { get; set; }

        [JsonPropertyName("height")]
        public DigitalTwinPropertyMetadata Height { get; set; }

        [JsonPropertyName("bmi")]
        public DigitalTwinPropertyMetadata BodyMassIndex { get; set; }
    }
}
