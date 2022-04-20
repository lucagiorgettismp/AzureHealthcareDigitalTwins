using Azure.DigitalTwins.Core;
using Client.Models;
using System.Text.Json.Serialization;

namespace Client.Api.DTLDModels
{
    class PatientTwin
    {
        private const string UNIT_BODY_MASS_INDEX = "Kg/m2";

        [JsonConstructor]
        public PatientTwin()
        {}

        public PatientTwin(PatientModel model, string modelId = "")
        {
            Metadata = new PatientTwinMetadata { ModelId = modelId };
            Name = model.Name;
            Surname = model.Surname;
            Age = model.Age;
            Gender = model.Gender;
            Description = model.Description;
            Weight = model.Weight;
            Height = model.Height;
            FiscalCode = model.FiscalCode;
            BodyMassIndex = new BodyMassIndexComponent
            {
                Value = model.BodyMassIndex,
                Unit = UNIT_BODY_MASS_INDEX
            };
        }

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

        [JsonPropertyName("bodymassindex")]
        public BodyMassIndexComponent BodyMassIndex { get; set; }

        [JsonPropertyName("fiscalcode")]
        public string FiscalCode { get; set; }
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

        [JsonPropertyName("bodymassindex")]
        public DigitalTwinPropertyMetadata BodyMassIndex { get; set; }

        [JsonPropertyName("fiscalcode")]
        public DigitalTwinPropertyMetadata FiscalCode { get; set; }
    }
}
