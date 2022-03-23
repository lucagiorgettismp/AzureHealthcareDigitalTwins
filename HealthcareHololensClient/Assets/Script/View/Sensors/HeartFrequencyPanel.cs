using Assets.Script.Utils;
using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class HeartFrequencyPanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro _date;
    private TextMeshPro _hour;

    /* Value */
    private TextMeshPro _heartFrequencyValue;
    private TextMeshPro _batteryValue;
   
    /* Sensor name */
    private TextMeshPro _heartFrequencySensorName;
    private TextMeshPro _batterySensorName;

    /* Symbol */
    private TextMeshPro _heartFrequencySymbol;
    private TextMeshPro _batterySymbol;

    /* Alert */
    private GameObject _heartFrequencyAlert;
    private GameObject _batteryAlert;

    /* Line Chart*/
    private WindowGraph _heartFrequencyGraph;

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
        this._date = GameObject.Find("DetailHeartFrequencyDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailHeartFrequencyHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._heartFrequencyValue = GameObject.Find("DetailHeartFrequencyValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailHeartFrequencyBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._heartFrequencySymbol = GameObject.Find("DetailHeartFrequencySymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailHeartFrequencyBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._heartFrequencySensorName = GameObject.Find("DetailHeartFrequencySensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailHeartFrequencyBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._heartFrequencyAlert = GameObject.Find("DetailHeartFrequencyAlert");
        this._batteryAlert = GameObject.Find("DetailHeartFrequencyBatteryAlert");

        /* Line chart components */
        this._heartFrequencyGraph = GameObject.Find("DetailHeartFrequencyLineChart").GetComponent<WindowGraph>();

        /* Load color resources */
        _redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        _whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this._heartFrequencyAlert.GetComponent<Renderer>().material = _whiteColor;
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
        this._heartFrequencySymbol.text = message.heart_frequency_sensor_value.symbol;
        this._batterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this._heartFrequencyValue.text = message.heart_frequency_sensor_value.value.ToString();
        this._batteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this._heartFrequencySensorName.text = message.heart_frequency_sensor_name;
        this._batterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._heartFrequencyAlert, message.heart_frequency_alarm);
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
        float yAxisMin = (float)message.heart_frequency_sensor_value.min_value;
        float yAxisMax = (float)message.heart_frequency_sensor_value.max_value;
        float value = (float)message.heart_frequency_sensor_value.value;

        string graphColor = (string)message.heart_frequency_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor);

        this._heartFrequencyGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
