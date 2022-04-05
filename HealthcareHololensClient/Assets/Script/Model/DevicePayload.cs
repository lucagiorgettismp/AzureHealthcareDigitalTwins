using Model;
using Newtonsoft.Json;
namespace Assets.Script.Model
{
    public class DevicePayload
    {
        [JsonProperty("configuration")]
        public ConfigurationPayloadData Configuration { get; set; }
    }
}
