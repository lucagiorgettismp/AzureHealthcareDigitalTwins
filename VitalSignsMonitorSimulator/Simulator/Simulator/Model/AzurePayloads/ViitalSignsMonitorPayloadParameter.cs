namespace Simulator.Simulator.Model
{
    using Newtonsoft.Json;

    class VitalSignsMonitorPayloadParameter<T>
    {
        public VitalSignsMonitorPayloadParameter(DeviceDataProperty<T> property, CrudMode mode)
        {
            this.Value = property.Value;
            this.InAlarm = property.InAlarm;
            this.UnitOfMeasurement = mode == CrudMode.Create ? property.UnitOfMeasurement : null;
        }

        [JsonProperty("value")]
        public T Value { get; set; }

        [JsonProperty("alarm")]
        public bool InAlarm { get; set; }

        [JsonProperty("unit")]
        public string UnitOfMeasurement { get; set; }
    }
}
