using Newtonsoft.Json; 
namespace AppFunctions.Model.Payload
{
    public class ConfigurationPayloadData: IEventGridMessagePayloadData
    {
        [JsonProperty("lastselectedview")]
        public int LastSelectedView { get; set; }
    }
}