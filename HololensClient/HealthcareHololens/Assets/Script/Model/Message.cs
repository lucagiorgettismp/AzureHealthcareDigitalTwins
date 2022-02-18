using Newtonsoft.Json;

public class Message
{
    [JsonProperty("temperature_sensor_name")]
    public string TemperatureSensorName { get; set; }

    [JsonProperty("temperature_alarm")]
    public bool TemperatureSensorAlarm { get; set; }

    [JsonProperty("temperature_sensor_value")]
    public SensorValue TemperatureSensorValue { get; set; }

    [JsonProperty("temperature_min_value")]
    public float TemperatureMinValue { get; set; }

    [JsonProperty("temperature_max_value")]
    public float TemperatureMaxValue { get; set; }


    [JsonProperty("blood_pressure_sensor_name")]
    public string BloodPressureSensorName { get; set; }

    [JsonProperty("blood_pressure_alarm")]
    public bool BloodPressureSensorAlarm { get; set; }

    [JsonProperty("blood_pressure_sensor_value")]
    public SensorValue BloodPressureSensorValue { get; set; }

    [JsonProperty("blood_pressure_min_value")]
    public float BloodPressureMinValue { get; set; }

    [JsonProperty("blood_pressure_max_value")]
    public float BloodPressureMaxValue { get; set; }


    [JsonProperty("battery_sensor_name")]
    public string BatterySensorName { get; set; }

    [JsonProperty("battery_alarm")]
    public bool BatterySensorAlarm { get; set; }

    [JsonProperty("battery_sensor_value")]
    public SensorValue BatterySensorValue { get; set; }

    [JsonProperty("battery_min_value")]
    public float BatteryMinValue { get; set; }

    [JsonProperty("battery_max_value")]
    public float BatteryMaxValue { get; set; }


    [JsonProperty("heart_frequency_sensor_name")]
    public string HeartFrequencySensorName { get; set; }

    [JsonProperty("heart_frequency_alarm")]
    public bool HeartFrequencySensorAlarm { get; set; }

    [JsonProperty("heart_frequency_sensor_value")]
    public SensorValue HeartFrequencySensorValue { get; set; }

    [JsonProperty("heart_frequency_min_value")]
    public float HeartFrequencyMinValue { get; set; }

    [JsonProperty("heart_frequency_max_value")]
    public float HeartFrequencyMaxValue { get; set; }


    [JsonProperty("breath_frequency_sensor_name")]
    public string BreathFrequencySensorName { get; set; }

    [JsonProperty("breath_frequency_alarm")]
    public bool BreathFrequencySensorAlarm { get; set; }

    [JsonProperty("breath_frequency_sensor_value")]
    public SensorValue BreathFrequencySensorValue { get; set; }

    [JsonProperty("breath_frequency_min_value")]
    public float BreathFrequencyMinValue { get; set; }

    [JsonProperty("breath_frequency_max_value")]
    public float BreathFrequencyMaxValue { get; set; }


    [JsonProperty("saturation_sensor_name")]
    public string SaturationSensorName { get; set; }

    [JsonProperty("saturation_alarm")]
    public bool SaturationSensorAlarm { get; set; }

    [JsonProperty("saturation_sensor_value")]
    public SensorValue SaturationSensorValue { get; set; }

    [JsonProperty("saturation_min_value")]
    public float SaturationMinValue { get; set; }

    [JsonProperty("saturation_max_value")]
    public float SaturationMaxValue { get; set; }
}