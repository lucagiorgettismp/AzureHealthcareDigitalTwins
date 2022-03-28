using Newtonsoft.Json;
namespace Simulator.Model.Payload
{
    public class Configuration
    {
        [JsonProperty("last_selected_view")]
        public int LastSelectedView { get; set; }
    }
}