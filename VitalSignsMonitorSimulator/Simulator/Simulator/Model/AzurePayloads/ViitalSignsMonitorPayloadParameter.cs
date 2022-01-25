﻿namespace Simulator.Simulator.Model
{
    using Newtonsoft.Json;

    class VitalSignsMonitorPayloadParameter
    {
        public VitalSignsMonitorPayloadParameter(DeviceDataProperty property, CrudMode mode)
        {
            this.InAlarm = property.InAlarm;
            this.UnitOfMeasurement = mode == CrudMode.Create ? property.UnitOfMeasurement : null;
        }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("alarm")]
        public bool InAlarm { get; set; }

        [JsonProperty("unit")]
        public string UnitOfMeasurement { get; set; }
    }
}
