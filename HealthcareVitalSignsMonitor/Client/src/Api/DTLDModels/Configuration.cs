using System.Text.Json.Serialization;

namespace Client.Api.DTLDModels
{
    public class Configuration
    {
        [JsonPropertyName("lastselectedview")]
        public int LastSelectedView { get; set; }
    }
}