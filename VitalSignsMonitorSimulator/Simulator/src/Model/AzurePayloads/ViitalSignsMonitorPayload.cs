namespace Model.AzurePayloads
{
    using Newtonsoft.Json;

    class VitalSignsMonitorPayload
    {
        [JsonProperty("mode")]
        public CrudMode Mode { get; set; }

        [JsonProperty("data")]
        public VitalSignsMonitorPayloadData Data { get; set; }
    }
}
