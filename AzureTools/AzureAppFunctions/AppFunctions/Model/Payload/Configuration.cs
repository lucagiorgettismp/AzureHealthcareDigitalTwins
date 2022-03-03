using Newtonsoft.Json;
namespace AppFunctions.Model.Payload
{

    public class Configuration
    {
        [JsonProperty("last_selected_view")]
        public int LastSelectedView { get; set; }
    }
}