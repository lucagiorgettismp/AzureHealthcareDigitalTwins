using Assets.Script.Utils;
using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class BreathFrequencyPanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro _date;
    private TextMeshPro _hour;

    /* Value */
    private TextMeshPro _breathFrequencyValue;
    private TextMeshPro _batteryValue;

    /* Sensor name */
    private TextMeshPro _breathFrequencySensorName;
    private TextMeshPro _batterySensorName;

    /* Symbol */
    private TextMeshPro _breathFrequencySymbol;
    private TextMeshPro _batterySymbol;

    /* Alert */
    private GameObject _breathFrequencyAlert;
    private GameObject _batteryAlert;

    /* Line Chart*/
    private WindowGraph _breathFrequencyGraph;

    /* Colors */
    const string RED_COLOR = "Materials/RedColor";
    const string WHITE_COLOR = "Materials/WhiteColor";

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
        this._date = GameObject.Find("DetailBreathFrequencyDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailBreathFrequencyHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._breathFrequencyValue = GameObject.Find("DetailBreathFrequencyValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailBreathFrequencyBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._breathFrequencySymbol = GameObject.Find("DetailBreathFrequencySymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailBreathFrequencyBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._breathFrequencySensorName = GameObject.Find("DetailBreathFrequencySensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailBreathFrequencyBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._breathFrequencyAlert = GameObject.Find("DetailBreathFrequencyAlert");
        this._batteryAlert = GameObject.Find("DetailBreathFrequencyBatteryAlert");

        /* Line chart components */
        this._breathFrequencyGraph = GameObject.Find("DetailBreathFrequencyLineChart").GetComponent<WindowGraph>();

        /* Load color resources */
        _redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        _whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this._breathFrequencyAlert.GetComponent<Renderer>().material = _whiteColor;
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
        }
        catch (Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }

    private void UpdateSensorSymbols(Message message)
    { 
        this._breathFrequencySymbol.text = message.breath_frequency_sensor_value.symbol;
        this._batterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this._breathFrequencyValue.text = message.breath_frequency_sensor_value.value.ToString();
        this._batteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this._breathFrequencySensorName.text = message.breath_frequency_sensor_name;
        this._batterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._breathFrequencyAlert, message.breath_frequency_alarm);
        SetSensorAlert(this._batteryAlert, message.battery_alarm);
    }

    private void SetSensorAlert(GameObject sensor, bool inAlarm)
    {
        sensor.GetComponent<Renderer>().material = inAlarm ? _redColor : _whiteColor;

        if (inAlarm)
        {
            sensor.GetComponent<AudioSource>().Play();
        }
    }

    private void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.breath_frequency_sensor_value.min_value;
        float yAxisMax = (float)message.breath_frequency_sensor_value.max_value;
        float value = (float)message.breath_frequency_sensor_value.value;

        string graphColor = (string)message.breath_frequency_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor);

        this._breathFrequencyGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
