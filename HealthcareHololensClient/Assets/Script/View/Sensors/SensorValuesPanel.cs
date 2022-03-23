using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class SensorValuesPanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro Date;
    private TextMeshPro Hour;

    /* Value */
    private TextMeshPro TemperatureValue;
    private TextMeshPro SaturationValue;
    private TextMeshPro BloodPressureValue;
    private TextMeshPro HeartFrequencyValue;
    private TextMeshPro BreathFrequencyValue;
    private TextMeshPro BatteryValue;

    /* Sensor name */
    private TextMeshPro TemperatureSensorName;
    private TextMeshPro SaturationSensorName;
    private TextMeshPro BloodPressureSensorName;
    private TextMeshPro HeartFrequencySensorName;
    private TextMeshPro BreathFrequencySensorName;
    private TextMeshPro BatterySensorName;

    /* Symbol */
    private TextMeshPro TemperatureSymbol;
    private TextMeshPro SaturationSymbol;
    private TextMeshPro BloodPressureSymbol;
    private TextMeshPro HeartFrequencySymbol;
    private TextMeshPro BreathFrequencySymbol;
    private TextMeshPro BatterySymbol;

    /* Alert */
    private GameObject TemperatureAlert;
    private GameObject SaturationAlert;
    private GameObject BloodPressureAlert;
    private GameObject HeartFrequencyAlert;
    private GameObject BreathFrequencyAlert;
    private GameObject BatteryAlert;

    /* Colors */
    const string RED_COLOR = "Materials/RedColor";
    const string WHITE_COLOR = "Materials/WhiteColor";

    Material RedColor;
    Material WhiteColor;

    public void Awake()
    {
        InitializedComponent();
    }

    public void Update()
    {
        var dateTime = DateTime.Now;
        this.Hour.text = dateTime.ToShortDateString();
        this.Date.text = dateTime.ToLongTimeString();
    }

    private void InitializedComponent()
    {
        /* Datetime components */
        this.Date = GameObject.Find("DetailValueDate").GetComponent<TextMeshPro>();
        this.Hour = GameObject.Find("DetailValueHour").GetComponent<TextMeshPro>();

        /* Value components */
        this.HeartFrequencyValue = GameObject.Find("DetailValueHeartFrequencyValue").GetComponent<TextMeshPro>();
        this.BreathFrequencyValue = GameObject.Find("DetailValueBreathFrequencyValue").GetComponent<TextMeshPro>();
        this.SaturationValue = GameObject.Find("DetailValueSaturationValue").GetComponent<TextMeshPro>();
        this.BloodPressureValue = GameObject.Find("DetailValueBloodPressureValue").GetComponent<TextMeshPro>();
        this.TemperatureValue = GameObject.Find("DetailValueTemperatureValue").GetComponent<TextMeshPro>();
        this.BatteryValue = GameObject.Find("DetailValueBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this.HeartFrequencySymbol = GameObject.Find("DetailValueHeartFrequencySymbol").GetComponent<TextMeshPro>();
        this.BreathFrequencySymbol = GameObject.Find("DetailValueBreathFrequencySymbol").GetComponent<TextMeshPro>();
        this.SaturationSymbol = GameObject.Find("DetailValueSaturationSymbol").GetComponent<TextMeshPro>();
        this.BloodPressureSymbol = GameObject.Find("DetailValueBloodPressureSymbol").GetComponent<TextMeshPro>();
        this.TemperatureSymbol = GameObject.Find("DetailValueTemperatureSymbol").GetComponent<TextMeshPro>();
        this.BatterySymbol = GameObject.Find("DetailValueBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.HeartFrequencySensorName = GameObject.Find("DetailValueHeartFrequencySensorName").GetComponent<TextMeshPro>();
        this.BreathFrequencySensorName = GameObject.Find("DetailValueBreathFrequencySensorName").GetComponent<TextMeshPro>();
        this.SaturationSensorName = GameObject.Find("DetailValueSaturationSensorName").GetComponent<TextMeshPro>();
        this.BloodPressureSensorName = GameObject.Find("DetailValueBloodPressureSensorName").GetComponent<TextMeshPro>();
        this.TemperatureSensorName = GameObject.Find("DetailValueTemperatureSensorName").GetComponent<TextMeshPro>();
        this.BatterySensorName = GameObject.Find("DetailValueBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.HeartFrequencyAlert = GameObject.Find("DetailValueHeartFrequencyAlert");
        this.BreathFrequencyAlert = GameObject.Find("DetailValueBreathFrequencyAlert");
        this.SaturationAlert = GameObject.Find("DetailValueSaturationAlert");
        this.BloodPressureAlert = GameObject.Find("DetailValueBloodPressureAlert");
        this.TemperatureAlert = GameObject.Find("DetailValueTemperatureAlert");
        this.BatteryAlert = GameObject.Find("DetailValueBatteryAlert");

        /* Load color resources */
        RedColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        WhiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.SaturationAlert.GetComponent<Renderer>().material = WhiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material = WhiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material = WhiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = WhiteColor;
        this.TemperatureAlert.GetComponent<Renderer>().material = WhiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = WhiteColor;
    }

    public void UpdateView(Message message)
    {
        try
        {
            UpdateSensorNames(message);
            UpdateSensorSymbols(message);
            UpdateSensorAlerts(message);
            UpdateSensorValues(message);
        }
        catch (Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }

    private void UpdateSensorSymbols(Message message)
    {
        this.TemperatureSymbol.text = message.temperature_sensor_value.symbol;
        this.SaturationSymbol.text = message.saturation_sensor_value.symbol;
        this.BloodPressureSymbol.text = message.blood_pressure_sensor_value.symbol;
        this.HeartFrequencySymbol.text = message.heart_frequency_sensor_value.symbol;
        this.BreathFrequencySymbol.text = message.breath_frequency_sensor_value.symbol;
        this.BatterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.TemperatureValue.text = Math.Round(message.temperature_sensor_value.value, 1).ToString();

        this.SaturationValue.text = message.saturation_sensor_value.value.ToString();
        this.SaturationValue.color = SplitColor((string)message.saturation_graph_color);

        this.BloodPressureValue.text = message.blood_pressure_sensor_value.value.ToString();
        this.BloodPressureValue.color = SplitColor((string)message.blood_pressure_graph_color);

        this.HeartFrequencyValue.text = message.heart_frequency_sensor_value.value.ToString();
        this.HeartFrequencyValue.color = SplitColor((string)message.heart_frequency_graph_color);

        this.BreathFrequencyValue.text = message.breath_frequency_sensor_value.value.ToString();
        this.BreathFrequencyValue.color = SplitColor((string)message.breath_frequency_graph_color);

        this.BatteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.TemperatureSensorName.text = message.temperature_sensor_name;
        this.SaturationSensorName.text = message.saturation_sensor_name;
        this.BloodPressureSensorName.text = message.blood_pressure_sensor_name;
        this.HeartFrequencySensorName.text = message.heart_frequency_sensor_name;
        this.BreathFrequencySensorName.text = message.breath_frequency_sensor_name;
        this.BatterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        SetAlertSensor(this.TemperatureAlert, message.temperature_alarm);
        SetAlertSensor(this.SaturationAlert, message.saturation_alarm);
        SetAlertSensor(this.BloodPressureAlert, message.blood_pressure_alarm);
        SetAlertSensor(this.HeartFrequencyAlert, message.heart_frequency_alarm);
        SetAlertSensor(this.BreathFrequencyAlert, message.breath_frequency_alarm);
        SetAlertSensor(this.BatteryAlert, message.battery_alarm);
    }

    private void SetAlertSensor(GameObject sensor, bool inAlarm)
    {
        sensor.GetComponent<Renderer>().material = inAlarm ? RedColor : WhiteColor;

        if (inAlarm)
        {
            sensor.GetComponent<AudioSource>().Play();
        }
    }

    private Color SplitColor(string color)
    {
        int channelR = Convert.ToInt32(color.Split(',')[0]);
        int channelG = Convert.ToInt32(color.Split(',')[1]);
        int channelB = Convert.ToInt32(color.Split(',')[2]);
        return new Color(channelR, channelG, channelB, 250f);
    }
}   
