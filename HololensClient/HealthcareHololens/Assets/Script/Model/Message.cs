using Newtonsoft.Json;

public class Message
{
    [JsonProperty("temperature_sensor_name")]
    public string TemperatureSensorName { get; set; }

    [JsonProperty("temperature_alarm")]
    public bool TemperatureSensorAlarm { get; set; }

    [JsonProperty("temperature_sensor_value")]
    public SensorValue TemperatureSensorValue { get; set; }


    [JsonProperty("blood_pressure_sensor_name")]
    public string BloodPressureSensorName { get; set; }

    [JsonProperty("blood_pressure_alarm")]
    public bool BloodPressureSensorAlarm { get; set; }

    [JsonProperty("blood_pressure_sensor_value")]
    public SensorValue BloodPressureSensorValue { get; set; }

    [JsonProperty("blood_pressure_graph_color")]
    public string BloodPressureGraphColor { get; set; }


    [JsonProperty("battery_sensor_name")]
    public string BatterySensorName { get; set; }

    [JsonProperty("battery_alarm")]
    public bool BatterySensorAlarm { get; set; }

    [JsonProperty("battery_sensor_value")]
    public SensorValue BatterySensorValue { get; set; }


    [JsonProperty("heart_frequency_sensor_name")]
    public string HeartFrequencySensorName { get; set; }

    [JsonProperty("heart_frequency_alarm")]
    public bool HeartFrequencySensorAlarm { get; set; }

    [JsonProperty("heart_frequency_sensor_value")]
    public SensorValue HeartFrequencySensorValue { get; set; }

    [JsonProperty("heart_frequency_graph_color")]
    public string HeartFrequencyGraphColor { get; set; }


    [JsonProperty("breath_frequency_sensor_name")]
    public string BreathFrequencySensorName { get; set; }

    [JsonProperty("breath_frequency_alarm")]
    public bool BreathFrequencySensorAlarm { get; set; }

    [JsonProperty("breath_frequency_sensor_value")]
    public SensorValue BreathFrequencySensorValue { get; set; }

    [JsonProperty("breath_frequency_graph_color")]
    public string BreathFrequencyGraphColor { get; set; }


    [JsonProperty("saturation_sensor_name")]
    public string SaturationSensorName { get; set; }

    [JsonProperty("saturation_alarm")]
    public bool SaturationSensorAlarm { get; set; }

    [JsonProperty("saturation_sensor_value")]
    public SensorValue SaturationSensorValue { get; set; }

    [JsonProperty("saturation_graph_color")]
    public string SaturationGraphColor { get; set; }
}