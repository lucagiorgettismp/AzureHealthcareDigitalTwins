using System.Text.Json.Serialization;

namespace Client.Api.DTLDModels
{
    class BodyMassIndexComponent
    {
        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
