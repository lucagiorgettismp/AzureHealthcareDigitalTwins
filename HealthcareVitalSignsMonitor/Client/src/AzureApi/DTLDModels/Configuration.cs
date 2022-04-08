using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Client.src.AzureApi.DTLDModels
{
    public class Configuration
    {
        [JsonPropertyName("lastselectedview")]
        public int LastSelectedView { get; set; }
    }
}