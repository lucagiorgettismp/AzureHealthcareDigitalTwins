using Newtonsoft.Json; 
namespace Model
{
    public class ConfigurationPayloadData
    {
        [JsonProperty("lastselectedview")]
        public int LastSelectedView { get; set; }
    }
}   