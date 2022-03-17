using Newtonsoft.Json; 
namespace Model
{

    public class ConfigurationPayloadData
    {
        [JsonProperty("last_selected_view")]
        public int LastSelectedView { get; set; }
    }

}