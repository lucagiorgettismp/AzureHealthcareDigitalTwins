using Newtonsoft.Json;

public class Message
{
    //[JsonProperty("temperature_value")]
    public double temperature_value { get; set; }

    [JsonProperty("temperature_alarm")]
    public bool TemperatureAlarm { get; set; }

    [JsonProperty("battery_value")]
    public int BatteryValue { get; set; }

    [JsonProperty("battery_alarm")]
    public bool BatteryAlarm { get; set; }

    [JsonProperty("saturation_value")]
    public int SaturationValue { get; set; }

    [JsonProperty("saturation_alarm")]
    public bool SaturationAlarm { get; set; }

    [JsonProperty("heart_frequency_value")]
    public int HeartFrequencyValue { get; set; }

    [JsonProperty("heart_frequency_alarm")]
    public bool HeartFrequencyAlarm { get; set; }

    [JsonProperty("blood_pressure_value")]
    public int BloodPressureValue { get; set; }

    [JsonProperty("blood_pressure_alarm")]
    public bool BloodPressureAlarm { get; set; }

    [JsonProperty("breath_frequency_alarm")]
    public bool BreathFrequencyAlarm { get; set; }

    [JsonProperty("breath_frequency_value")]
    public int BreathFrequencyValue { get; set; }
}