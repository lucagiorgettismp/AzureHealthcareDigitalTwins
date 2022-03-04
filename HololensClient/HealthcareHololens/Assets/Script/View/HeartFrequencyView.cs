using System;
using TMPro;
using UnityEngine;

public class HeartFrequencyView : MonoBehaviour
{
    /* Datetime */
    private TextMeshPro Date;
    private TextMeshPro Hour;

    /* Value */
    private TextMeshPro HeartFrequencyValue;
    private TextMeshPro BatteryValue;

    /* Sensor name */
    private TextMeshPro HeartFrequencySensorName;
    private TextMeshPro BatterySensorName;

    /* Symbol */
    private TextMeshPro HeartFrequencySymbol;
    private TextMeshPro BatterySymbol;

    /* Alert */
    private GameObject HeartFrequencyAlert;
    private GameObject BatteryAlert;

    /* Line Chart*/
    private WindowGraph HeartFrequencyGraph;

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
        this.Hour.text = dateTime.ToShortDateString();
        this.Date.text = dateTime.ToLongTimeString();
    }

    private void InitializedComponent()
    {
        /* Datetime components */
        this.Date = GameObject.Find("DetailHeartFrequencyDate").GetComponent<TextMeshPro>();
        this.Hour = GameObject.Find("DetailHeartFrequencyHour").GetComponent<TextMeshPro>();

        /* Value components */
        this.HeartFrequencyValue = GameObject.Find("DetailHeartFrequencyValue").GetComponent<TextMeshPro>();
        this.BatteryValue = GameObject.Find("DetailHeartFrequencyBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this.HeartFrequencySymbol = GameObject.Find("DetailHeartFrequencySymbol").GetComponent<TextMeshPro>();
        this.BatterySymbol = GameObject.Find("DetailHeartFrequencyBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.HeartFrequencySensorName = GameObject.Find("DetailHeartFrequencySensorName").GetComponent<TextMeshPro>();
        this.BatterySensorName = GameObject.Find("DetailHeartFrequencyBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.HeartFrequencyAlert = GameObject.Find("DetailHeartFrequencyAlert");
        this.BatteryAlert = GameObject.Find("DetailHeartFrequencyBatteryAlert");

        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.HeartFrequencyAlert.GetComponent<Renderer>().material = whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = whiteColor;

        /* Line chart components */
        this.HeartFrequencyGraph = GameObject.Find("DetailHeartFrequencyLineChart").GetComponent<WindowGraph>();
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
        this.HeartFrequencySymbol.text = message.heart_frequency_sensor_value.symbol;
        this.BatterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.HeartFrequencyValue.text = message.heart_frequency_sensor_value.value.ToString();
        this.BatteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.HeartFrequencySensorName.text = message.heart_frequency_sensor_name;
        this.BatterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        Material redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.HeartFrequencyAlert.GetComponent<Renderer>().material = message.heart_frequency_alarm ? redColor : whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = message.battery_alarm ? redColor : whiteColor;
    }

    private void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.heart_frequency_sensor_value.min_value;
        float yAxisMax = (float)message.heart_frequency_sensor_value.max_value;
        float value = (float)message.heart_frequency_sensor_value.value;

        string graphColor = (string)message.heart_frequency_graph_color;
        int channelR = Convert.ToInt32(graphColor.Split(',')[0]);
        int channelG = Convert.ToInt32(graphColor.Split(',')[1]);
        int channelB = Convert.ToInt32(graphColor.Split(',')[2]);
        Color color = new Color(channelR, channelG, channelB, 250f);

        this.HeartFrequencyGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
