using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class SaturationPanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro Date;
    private TextMeshPro Hour;

    /* Value */
    private TextMeshPro SaturationValue;
    private TextMeshPro BatteryValue;

    /* Sensor name */
    private TextMeshPro SaturationSensorName;
    private TextMeshPro BatterySensorName;

    /* Symbol */
    private TextMeshPro SaturationSymbol;
    private TextMeshPro BatterySymbol;

    /* Alert */
    private GameObject SaturationAlert;
    private GameObject BatteryAlert;

    /* Line Chart*/
    private WindowGraph SaturationGraph;

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
        this.Date = GameObject.Find("DetailSaturationDate").GetComponent<TextMeshPro>();
        this.Hour = GameObject.Find("DetailSaturationHour").GetComponent<TextMeshPro>();

        /* Value components */
        this.SaturationValue = GameObject.Find("DetailSaturationValue").GetComponent<TextMeshPro>();
        this.BatteryValue = GameObject.Find("DetailSaturationBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this.SaturationSymbol = GameObject.Find("DetailSaturationSymbol").GetComponent<TextMeshPro>();
        this.BatterySymbol = GameObject.Find("DetailSaturationBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.SaturationSensorName = GameObject.Find("DetailSaturationSensorName").GetComponent<TextMeshPro>();
        this.BatterySensorName = GameObject.Find("DetailSaturationBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.SaturationAlert = GameObject.Find("DetailSaturationAlert");
        this.BatteryAlert = GameObject.Find("DetailSaturationBatteryAlert");


        /* Line chart components */
        this.SaturationGraph = GameObject.Find("DetailSaturationLineChart").GetComponent<WindowGraph>();

        /* Load color resources */
        RedColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        WhiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.SaturationAlert.GetComponent<Renderer>().material = WhiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = WhiteColor;
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
        this.SaturationSymbol.text = message.saturation_sensor_value.symbol;
        this.BatterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.SaturationValue.text = message.saturation_sensor_value.value.ToString();
        this.BatteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.SaturationSensorName.text = message.saturation_sensor_name;
        this.BatterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        SetAlertSensor(this.SaturationAlert, message.saturation_alarm);
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

    private void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.saturation_sensor_value.min_value;
        float yAxisMax = (float)message.saturation_sensor_value.max_value;
        float value = (float)message.saturation_sensor_value.value;

        string graphColor = (string)message.saturation_graph_color;
        int channelR = Convert.ToInt32(graphColor.Split(',')[0]);
        int channelG = Convert.ToInt32(graphColor.Split(',')[1]);
        int channelB = Convert.ToInt32(graphColor.Split(',')[2]);
        Color color = new Color(channelR, channelG, channelB, 250f);

        this.SaturationGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
