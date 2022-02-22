using System;
using TMPro;
using UnityEngine;

public class SaturationView : BaseApplicationPanel
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

        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.SaturationAlert.GetComponent<Renderer>().material = whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = whiteColor;

        /* Line chart components */
        this.SaturationGraph = GameObject.Find("DetailSaturationLineChart").GetComponent<WindowGraph>();
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
        this.SaturationSymbol.text = message.SaturationSensorValue.Symbol;
        this.BatterySymbol.text = message.BatterySensorValue.Symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.SaturationValue.text = message.SaturationSensorValue.Value.ToString();
        this.BatteryValue.text = message.BatterySensorValue.Value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.SaturationSensorName.text = message.SaturationSensorName;
        this.BatterySensorName.text = message.BatterySensorName;
    }

    private void UpdateSensorAlerts(Message message)
    {
        Material redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.SaturationAlert.GetComponent<Renderer>().material = message.SaturationSensorAlarm ? redColor : whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = message.BatterySensorAlarm ? redColor : whiteColor;
    }

    private void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.SaturationSensorValue.MinValue;
        float yAxisMax = (float)message.SaturationSensorValue.MaxValue;
        float value = (float)message.SaturationSensorValue.Value;

        string graphColor = (string)message.SaturationGraphColor;
        int channelR = Convert.ToInt32(graphColor.Split(',')[0]);
        int channelG = Convert.ToInt32(graphColor.Split(',')[1]);
        int channelB = Convert.ToInt32(graphColor.Split(',')[2]);
        Color color = new Color(channelR, channelG, channelB, 250f);

        this.SaturationGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
