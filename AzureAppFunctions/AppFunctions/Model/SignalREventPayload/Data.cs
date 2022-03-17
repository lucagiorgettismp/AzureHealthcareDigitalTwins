using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace AppFunctions.Model.SignalREventPayload{ 

    public class Data
    {
        [JsonProperty("modelId")]
        public string ModelId;

        [JsonProperty("patch")]
        public List<Patch> Patch;
    }

}