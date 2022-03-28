using Newtonsoft.Json; 
namespace AppFunctions.Model.SignalREventPayload
{
    public class Patch
    {
        [JsonProperty("value")]
        public object Value;

        [JsonProperty("path")]
        public string Path;

        [JsonProperty("op")]
        public string Op;
    }
}