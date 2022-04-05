using Newtonsoft.Json;
namespace Simulator.Model.Settings
{
    public class SensorSettingsMinThreashold<T> : SensorSettings<T>
    {
        [JsonProperty("min_alert_threashold")]
        public T MinAlertThreashold { get; set; }
    }
}