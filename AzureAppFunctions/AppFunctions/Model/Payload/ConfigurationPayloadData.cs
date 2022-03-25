using Newtonsoft.Json; 
namespace AppFunctions.Model.Payload
{
    public class ConfigurationPayloadData: IEventGridMessagePayloadData
    {
        [JsonProperty("last_selected_view")]
        public int LastSelectedView { get; set; }
    }
}