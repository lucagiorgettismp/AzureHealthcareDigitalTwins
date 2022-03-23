using Assets.Script.Utils;
using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class BloodPressurePanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro _date;
    private TextMeshPro _hour;

    /* Value */
    private TextMeshPro _bloodPressureValue;
    private TextMeshPro _batteryValue;

    /* Sensor name */
    private TextMeshPro _bloodPressureSensorName;
    private TextMeshPro _batterySensorName;

    /* Symbol */
    private TextMeshPro _bloodPressureSymbol;
    private TextMeshPro _batterySymbol;

    /* Alert */
    private GameObject _bloodPressureAlert;
    private GameObject _batteryAlert;

    private Material _redColor;
    private Material _whiteColor;

    /* Line Chart*/
    public WindowGraph _bloodPressureGraph;

    /* Colors */
    const string RED_COLOR = "Materials/RedColor";
    const string WHITE_COLOR = "Materials/WhiteColor";

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
        this._date = GameObject.Find("DetailBloodPressureDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailBloodPressureHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._bloodPressureValue = GameObject.Find("DetailBloodPressureValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailBloodPressureBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._bloodPressureSymbol = GameObject.Find("DetailBloodPressureSymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailBloodPressureBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._bloodPressureSensorName = GameObject.Find("DetailBloodPressureSensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailBloodPressureBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._bloodPressureAlert = GameObject.Find("DetailBloodPressureAlert");
        this._batteryAlert = GameObject.Find("DetailBloodPressureBatteryAlert");

        /* Line chart components */
        this._bloodPressureGraph = GameObject.Find("DetailBloodPressureLineChart").GetComponent<WindowGraph>();

        /* Load color resources */
        _redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        _whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this._bloodPressureAlert.GetComponent<Renderer>().material = _whiteColor;
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
        this._bloodPressureSymbol.text = message.blood_pressure_sensor_value.symbol;
        this._batterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this._bloodPressureValue.text = message.blood_pressure_sensor_value.value.ToString();
        this._batteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this._bloodPressureSensorName.text = message.blood_pressure_sensor_name;
        this._batterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._bloodPressureAlert, message.blood_pressure_alarm);
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
        float yAxisMin  = (float)message.blood_pressure_sensor_value.min_value;
        float yAxisMax  = (float)message.blood_pressure_sensor_value.max_value;
        float value     = (float)message.blood_pressure_sensor_value.value;

        string graphColor = (string) message.blood_pressure_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor); 

        this._bloodPressureGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
