using System;
using TMPro;
using UnityEngine;

public class BloodPressureView : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro Date;
    private TextMeshPro Hour;

    /* Value */
    private TextMeshPro BloodPressureValue;
    private TextMeshPro BatteryValue;

    /* Sensor name */
    private TextMeshPro BloodPressureSensorName;
    private TextMeshPro BatterySensorName;

    /* Symbol */
    private TextMeshPro BloodPressureSymbol;
    private TextMeshPro BatterySymbol;

    /* Alert */
    private GameObject BloodPressureAlert;
    private GameObject BatteryAlert;

    /* Line Chart*/
    private WindowGraph BloodPressureGraph;

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
        this.Date = GameObject.Find("DetailBloodPressureDate").GetComponent<TextMeshPro>();
        this.Hour = GameObject.Find("DetailBloodPressureHour").GetComponent<TextMeshPro>();

        /* Value components */
        this.BloodPressureValue = GameObject.Find("DetailBloodPressureValue").GetComponent<TextMeshPro>();
        this.BatteryValue = GameObject.Find("DetailBloodPressureBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this.BloodPressureSymbol = GameObject.Find("DetailBloodPressureSymbol").GetComponent<TextMeshPro>();
        this.BatterySymbol = GameObject.Find("DetailBloodPressureBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.BloodPressureSensorName = GameObject.Find("DetailBloodPressureSensorName").GetComponent<TextMeshPro>();
        this.BatterySensorName = GameObject.Find("DetailBloodPressureBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.BloodPressureAlert = GameObject.Find("DetailBloodPressureAlert");
        this.BatteryAlert = GameObject.Find("DetailBloodPressureBatteryAlert");

        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.BloodPressureAlert.GetComponent<Renderer>().material = whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = whiteColor;

        /* Line chart components */
        this.BloodPressureGraph = GameObject.Find("DetailBloodPressureLineChart").GetComponent<WindowGraph>();
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
        this.BloodPressureSymbol.text = message.blood_pressure_sensor_value.symbol;
        this.BatterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.BloodPressureValue.text = message.blood_pressure_sensor_value.value.ToString();
        this.BatteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.BloodPressureSensorName.text = message.blood_pressure_sensor_name;
        this.BatterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        Material redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.BloodPressureAlert.GetComponent<Renderer>().material = message.blood_pressure_alarm ? redColor : whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = message.battery_alarm ? redColor : whiteColor;
    }

    private void UpdateLineCharts(Message message)
    {
        float yAxisMin  = (float)message.blood_pressure_sensor_value.min_value;
        float yAxisMax  = (float)message.blood_pressure_sensor_value.max_value;
        float value     = (float)message.blood_pressure_sensor_value.value;

        string graphColor = (string) message.blood_pressure_graph_color;
        int channelR = Convert.ToInt32(graphColor.Split(',')[0]);
        int channelG = Convert.ToInt32(graphColor.Split(',')[1]);
        int channelB = Convert.ToInt32(graphColor.Split(',')[2]);
        Color color = new Color(channelR, channelG, channelB, 250f);

        this.BloodPressureGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
