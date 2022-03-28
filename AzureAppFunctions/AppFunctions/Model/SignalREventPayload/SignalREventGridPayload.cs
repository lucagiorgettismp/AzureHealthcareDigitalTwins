using Newtonsoft.Json; 
namespace AppFunctions.Model.SignalREventPayload
{ 
    public class SignalREventGridPayload
    {
        [JsonProperty("data")]
        public Data Data;

        [JsonProperty("contenttype")]
        public string Contenttype;

        [JsonProperty("traceparent")]
        public string Traceparent;
    }
}