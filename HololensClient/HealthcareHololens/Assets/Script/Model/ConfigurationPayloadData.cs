using Newtonsoft.Json; 
namespace Models
{

    public class ConfigurationPayloadData
    {
        [JsonProperty("last_selected_view")]
        public int LastSelectedView { get; set; }
    }

}