using System.Text.Json.Serialization;
using Azure.DigitalTwins.Core;

namespace Client.Api.DTLDModels
{
    class GraphSensorComponent : SensorComponent
    {
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.DigitalTwinMetadata)]
        public GraphSensorComponentMetadata Metadata { get; set; } = new GraphSensorComponentMetadata();

        [JsonPropertyName("graph_color")]
        public string GraphColor { get; set; }
    }

    internal class GraphSensorComponentMetadata : SensorComponentMetadata
    {
        [JsonPropertyName("graph_color")]
        public DigitalTwinPropertyMetadata GraphColor { get; set; }
    }
}
