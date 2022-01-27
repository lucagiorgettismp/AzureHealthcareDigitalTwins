namespace Simulator.Model.AzurePayloads
{
    using Newtonsoft.Json;

    public class VitalSignsMonitorPayloadParameter<T>
    {
        [JsonProperty("value")]
        public T Value { get; set; }

        [JsonProperty("alarm")]
        public bool InAlarm { get; set; }

        [JsonProperty("unit")]
        public string UnitOfMeasurement { get; set; }
    }
}
