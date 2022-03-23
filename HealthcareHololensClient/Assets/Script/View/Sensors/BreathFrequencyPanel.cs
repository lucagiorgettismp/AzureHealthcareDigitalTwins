using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class BreathFrequencyPanel : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro Date;
    private TextMeshPro Hour;

    /* Value */
    private TextMeshPro BreathFrequencyValue;
    private TextMeshPro BatteryValue;

    /* Sensor name */
    private TextMeshPro BreathFrequencySensorName;
    private TextMeshPro BatterySensorName;

    /* Symbol */
    private TextMeshPro BreathFrequencySymbol;
    private TextMeshPro BatterySymbol;

    /* Alert */
    private GameObject BreathFrequencyAlert;
    private GameObject BatteryAlert;

    /* Line Chart*/
    private WindowGraph BreathFrequencyGraph;

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
        this.Date = GameObject.Find("DetailBreathFrequencyDate").GetComponent<TextMeshPro>();
        this.Hour = GameObject.Find("DetailBreathFrequencyHour").GetComponent<TextMeshPro>();

        /* Value components */
        this.BreathFrequencyValue = GameObject.Find("DetailBreathFrequencyValue").GetComponent<TextMeshPro>();
        this.BatteryValue = GameObject.Find("DetailBreathFrequencyBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this.BreathFrequencySymbol = GameObject.Find("DetailBreathFrequencySymbol").GetComponent<TextMeshPro>();
        this.BatterySymbol = GameObject.Find("DetailBreathFrequencyBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.BreathFrequencySensorName = GameObject.Find("DetailBreathFrequencySensorName").GetComponent<TextMeshPro>();
        this.BatterySensorName = GameObject.Find("DetailBreathFrequencyBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.BreathFrequencyAlert = GameObject.Find("DetailBreathFrequencyAlert");
        this.BatteryAlert = GameObject.Find("DetailBreathFrequencyBatteryAlert");

        /* Line chart components */
        this.BreathFrequencyGraph = GameObject.Find("DetailBreathFrequencyLineChart").GetComponent<WindowGraph>();

        /* Load color resources */
        RedColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        WhiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.BreathFrequencyAlert.GetComponent<Renderer>().material = WhiteColor;
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
        this.BreathFrequencySymbol.text = message.breath_frequency_sensor_value.symbol;
        this.BatterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.BreathFrequencyValue.text = message.breath_frequency_sensor_value.value.ToString();
        this.BatteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.BreathFrequencySensorName.text = message.breath_frequency_sensor_name;
        this.BatterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
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

    private void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.breath_frequency_sensor_value.min_value;
        float yAxisMax = (float)message.breath_frequency_sensor_value.max_value;
        float value = (float)message.breath_frequency_sensor_value.value;

        string graphColor = (string)message.breath_frequency_graph_color;
        int channelR = Convert.ToInt32(graphColor.Split(',')[0]);
        int channelG = Convert.ToInt32(graphColor.Split(',')[1]);
        int channelB = Convert.ToInt32(graphColor.Split(',')[2]);
        Color color = new Color(channelR, channelG, channelB, 250f);

        this.BreathFrequencyGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
