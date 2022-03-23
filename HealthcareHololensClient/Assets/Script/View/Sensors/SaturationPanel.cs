using Assets.Script.Utils;
using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class SaturationPanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro _date;
    private TextMeshPro _hour;

    /* Value */
    private TextMeshPro _saturationValue;
    private TextMeshPro _batteryValue;

    /* Sensor name */
    private TextMeshPro _saturationSensorName;
    private TextMeshPro _batterySensorName;

    /* Symbol */
    private TextMeshPro _saturationSymbol;
    private TextMeshPro _batterySymbol;

    /* Alert */
    private GameObject _saturationAlert;
    private GameObject _batteryAlert;

    /* Line Chart*/
    private WindowGraph _saturationGraph;

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
        this._date = GameObject.Find("DetailSaturationDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailSaturationHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._saturationValue = GameObject.Find("DetailSaturationValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailSaturationBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._saturationSymbol = GameObject.Find("DetailSaturationSymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailSaturationBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._saturationSensorName = GameObject.Find("DetailSaturationSensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailSaturationBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._saturationAlert = GameObject.Find("DetailSaturationAlert");
        this._batteryAlert = GameObject.Find("DetailSaturationBatteryAlert");


        /* Line chart components */
        this._saturationGraph = GameObject.Find("DetailSaturationLineChart").GetComponent<WindowGraph>();

        /* Load color resources */
        _redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        _whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this._saturationAlert.GetComponent<Renderer>().material = _whiteColor;
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
        this._saturationSymbol.text = message.saturation_sensor_value.symbol;
        this._batterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this._saturationValue.text = message.saturation_sensor_value.value.ToString();
        this._batteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this._saturationSensorName.text = message.saturation_sensor_name;
        this._batterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._saturationAlert, message.saturation_alarm);
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
        float yAxisMin = (float)message.saturation_sensor_value.min_value;
        float yAxisMax = (float)message.saturation_sensor_value.max_value;
        float value = (float)message.saturation_sensor_value.value;

        string graphColor = (string)message.saturation_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor);

        this._saturationGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
