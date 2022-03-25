using Newtonsoft.Json;
namespace Client.src.AzureApi.DTLDModels
{
    public class Configuration
    {
        [JsonProperty("last_selected_view")]
        public int LastSelectedView { get; set; }
    }
}