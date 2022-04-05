using Newtonsoft.Json;
namespace Simulator.Model.Settings
{
    public class SensorSettingsMinMaxThreashold<T> : SensorSettingsMinThreashold<T>
    {
        [JsonProperty("max_alert_threashold")]
        public T MaxAlertThreashold { get; set; }
    }
}