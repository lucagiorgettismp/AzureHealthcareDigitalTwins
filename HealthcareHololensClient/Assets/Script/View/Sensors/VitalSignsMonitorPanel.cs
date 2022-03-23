using UnityEngine;
using TMPro;
using System;
using Assets.Script.View;
using Assets.Script.Utils;

public class VitalSignsMonitorPanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro _date;
    private TextMeshPro _hour;

    /* Value */
    private TextMeshPro _temperatureValue;
    private TextMeshPro _saturationValue;
    private TextMeshPro _bloodPressureValue;
    private TextMeshPro _heartFrequencyValue;
    private TextMeshPro _breathFrequencyValue;
    private TextMeshPro _batteryValue;

    /* Sensor name */
    private TextMeshPro _temperatureSensorName;
    private TextMeshPro _saturationSensorName;
    private TextMeshPro _bloodPressureSensorName;
    private TextMeshPro _heartFrequencySensorName;
    private TextMeshPro _breathFrequencySensorName;
    private TextMeshPro _batterySensorName;

    /* Symbol */
    private TextMeshPro _temperatureSymbol;
    private TextMeshPro _saturationSymbol;
    private TextMeshPro _bloodPressureSymbol;
    private TextMeshPro _heartFrequencySymbol;
    private TextMeshPro _breathFrequencySymbol;
    private TextMeshPro _batterySymbol;

    /* Alert */
    private GameObject _temperatureAlert;
    private GameObject _saturationAlert;
    private GameObject _bloodPressureAlert;
    private GameObject _heartFrequencyAlert;
    private GameObject _breathFrequencyAlert;
    private GameObject _batteryAlert;

    /* Colors */
    const string RED_COLOR = "Materials/RedColor";
    const string WHITE_COLOR = "Materials/WhiteColor";

    /* Line Chart*/
    private WindowGraph _heartFrequencyGraph;
    private WindowGraph _breathFrequencyGraph;
    private WindowGraph _saturationGraph;
    private WindowGraph _bloodPressureGraph;

    private Material _redColor;
    private Material _whiteColor;

    public void Awake()
    {
        InitializedComponent();
    }

    public void Update()
    {   
        var dateTime = DateTime.Now;
        this._hour.text = dateTime.ToShortDateString();
        this._date.text = dateTime.ToLongTimeString();
    }

    private void InitializedComponent()
    {
        /* Datetime components */
        this._date = GameObject.Find("Date").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("Hour").GetComponent<TextMeshPro>();

        /* Value components */
        this._heartFrequencyValue = GameObject.Find("HeartFrequencyValue").GetComponent<TextMeshPro>();
        this._breathFrequencyValue = GameObject.Find("BreathFrequencyValue").GetComponent<TextMeshPro>();
        this._saturationValue = GameObject.Find("SaturationValue").GetComponent<TextMeshPro>();
        this._heartFrequencyValue = GameObject.Find("HeartFrequencyValue").GetComponent<TextMeshPro>();
        this._bloodPressureValue = GameObject.Find("BloodPressureValue").GetComponent<TextMeshPro>();
        this._temperatureValue = GameObject.Find("TemperatureValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("BatteryValue").GetComponent<TextMeshPro>();


        /* Symbol components */
        this._heartFrequencySymbol = GameObject.Find("HeartFrequencySymbol").GetComponent<TextMeshPro>();
        this._breathFrequencySymbol = GameObject.Find("BreathFrequencySymbol").GetComponent<TextMeshPro>();
        this._saturationSymbol = GameObject.Find("SaturationSymbol").GetComponent<TextMeshPro>();
        this._heartFrequencySymbol = GameObject.Find("HeartFrequencySymbol").GetComponent<TextMeshPro>();
        this._bloodPressureSymbol = GameObject.Find("BloodPressureSymbol").GetComponent<TextMeshPro>();
        this._temperatureSymbol = GameObject.Find("TemperatureSymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("BatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._heartFrequencySensorName = GameObject.Find("HeartFrequencySensorName").GetComponent<TextMeshPro>();
        this._breathFrequencySensorName = GameObject.Find("BreathFrequencySensorName").GetComponent<TextMeshPro>();
        this._saturationSensorName = GameObject.Find("SaturationSensorName").GetComponent<TextMeshPro>();
        this._heartFrequencySensorName = GameObject.Find("HeartFrequencySensorName").GetComponent<TextMeshPro>();
        this._bloodPressureSensorName = GameObject.Find("BloodPressureSensorName").GetComponent<TextMeshPro>();
        this._temperatureSensorName = GameObject.Find("TemperatureSensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("BatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._heartFrequencyAlert = GameObject.Find("HeartFrequencyAlert");
        this._breathFrequencyAlert = GameObject.Find("BreathFrequencyAlert");
        this._saturationAlert = GameObject.Find("SaturationAlert");
        this._bloodPressureAlert = GameObject.Find("BloodPressureAlert");
        this._temperatureAlert = GameObject.Find("TemperatureAlert");
        this._batteryAlert = GameObject.Find("BatteryAlert");

        /* Line chart components */
        this._heartFrequencyGraph  = GameObject.Find("HeartFrequencyLineChart").GetComponent<WindowGraph>();
        this._breathFrequencyGraph = GameObject.Find("BreathFrequencyLineChart").GetComponent<WindowGraph>();
        this._saturationGraph = GameObject.Find("SaturationLineChart").GetComponent<WindowGraph>();
        this._bloodPressureGraph = GameObject.Find("BloodPressureLineChart").GetComponent<WindowGraph>();

        /* Load color resources */
        _redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        _whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this._saturationAlert.GetComponent<Renderer>().material = _whiteColor;
        this._bloodPressureAlert.GetComponent<Renderer>().material = _whiteColor;
        this._heartFrequencyAlert.GetComponent<Renderer>().material = _whiteColor;
        this._breathFrequencyAlert.GetComponent<Renderer>().material = _whiteColor;
        this._temperatureAlert.GetComponent<Renderer>().material = _whiteColor;
        this._batteryAlert.GetComponent<Renderer>().material = _whiteColor;
    }

    public void UpdateView(Message message)
    {
        try
        {
            UpdateLineCharts(message);
            UpdateSensorNames(message);
            UpdateSensorSymbols(message);
            UpdateSensorAlerts(message);
            UpdateSensorValues(message);
        }catch(Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }

    private void UpdateSensorSymbols(Message message)
    {
        this._temperatureSymbol.text = message.temperature_sensor_value.symbol;
        this._saturationSymbol.text = message.saturation_sensor_value.symbol;
        this._bloodPressureSymbol.text = message.blood_pressure_sensor_value.symbol;
        this._heartFrequencySymbol.text = message.heart_frequency_sensor_value.symbol;
        this._breathFrequencySymbol.text = message.breath_frequency_sensor_value.symbol;
        this._batterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this._temperatureValue.text = Math.Round(message.temperature_sensor_value.value, 1).ToString();
        this._saturationValue.text = message.saturation_sensor_value.value.ToString();
        this._bloodPressureValue.text = message.blood_pressure_sensor_value.value.ToString();
        this._heartFrequencyValue.text = message.heart_frequency_sensor_value.value.ToString();
        this._breathFrequencyValue.text = message.breath_frequency_sensor_value.value.ToString();
        this._batteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this._temperatureSensorName.text = message.temperature_sensor_name;
        this._saturationSensorName.text = message.saturation_sensor_name;
        this._bloodPressureSensorName.text = message.blood_pressure_sensor_name;
        this._heartFrequencySensorName.text = message.heart_frequency_sensor_name;
        this._breathFrequencySensorName.text = message.breath_frequency_sensor_name;
        this._batterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._temperatureAlert, message.temperature_alarm);
        SetSensorAlert(this._saturationAlert, message.saturation_alarm);
        SetSensorAlert(this._bloodPressureAlert, message.blood_pressure_alarm);
        SetSensorAlert(this._heartFrequencyAlert, message.heart_frequency_alarm);
        SetSensorAlert(this._breathFrequencyAlert, message.breath_frequency_alarm);
        SetSensorAlert(this._batteryAlert, message.battery_alarm);
    }

    private void SetSensorAlert(GameObject sensor, bool inAlarm)
    {
        sensor.GetComponent<Renderer>().material = inAlarm? _redColor : _whiteColor;

        if (inAlarm)
        {
            sensor.GetComponent<AudioSource>().Play();
        }
    }

    private void UpdateLineCharts(Message message)
    {
        Color HearthFrequencyColor = ColorUtils.GetColorByString((string)message.heart_frequency_graph_color);
        this._heartFrequencyGraph.AddPoint((float)message.heart_frequency_sensor_value.value,
                                          (float)message.heart_frequency_sensor_value.min_value,
                                          (float)message.heart_frequency_sensor_value.max_value,
                                          HearthFrequencyColor);

        Color BreathFrequencyColor = ColorUtils.GetColorByString((string)message.breath_frequency_graph_color);
        this._breathFrequencyGraph.AddPoint((float)message.breath_frequency_sensor_value.value,
                                           (float)message.breath_frequency_sensor_value.min_value,
                                           (float)message.breath_frequency_sensor_value.max_value,
                                           BreathFrequencyColor);

        Color SaturationColor = ColorUtils.GetColorByString((string)message.saturation_graph_color);
        this._saturationGraph.AddPoint((float)message.saturation_sensor_value.value,
                                      (float)message.saturation_sensor_value.min_value,
                                      (float)message.saturation_sensor_value.max_value,
                                      SaturationColor);

        Color BloodPressureColor = ColorUtils.GetColorByString((string)message.blood_pressure_graph_color);
        this._bloodPressureGraph.AddPoint((float)message.blood_pressure_sensor_value.value,
                                         (float)message.blood_pressure_sensor_value.min_value,
                                         (float)message.blood_pressure_sensor_value.max_value,
                                         BloodPressureColor);
    }
}
