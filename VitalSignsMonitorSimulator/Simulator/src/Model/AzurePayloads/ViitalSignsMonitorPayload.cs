namespace Simulator.Model.AzurePayloads
{
    using Common.Enums;
    using Newtonsoft.Json;

    public class VitalSignsMonitorPayload
    {
        [JsonProperty("mode")]
        public CrudMode Mode { get; set; }

        [JsonProperty("data")]
        public VitalSignsMonitorPayloadData Data { get; set; }
    }
}
