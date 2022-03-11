using UnityEngine;
using TMPro;
using System;

public class VitalSignsMonitorView : BaseApplicationPanel
{
    /* Datetime */
    private TextMeshPro Date;
    private TextMeshPro Hour;

    /* Value */
    private TextMeshPro TemperatureValue;
    private TextMeshPro SaturationValue;
    private TextMeshPro BloodPressureValue;
    private TextMeshPro HeartFrequencyValue;
    private TextMeshPro BreathFrequencyValue;
    private TextMeshPro BatteryValue;

    /* Sensor name */
    private TextMeshPro TemperatureSensorName;

    private TextMeshPro SaturationSensorName;
    private TextMeshPro BloodPressureSensorName;
    private TextMeshPro HeartFrequencySensorName;
    private TextMeshPro BreathFrequencySensorName;
    private TextMeshPro BatterySensorName;

    /* Symbol */
    private TextMeshPro TemperatureSymbol;
    private TextMeshPro SaturationSymbol;
    private TextMeshPro BloodPressureSymbol;
    private TextMeshPro HeartFrequencySymbol;
    private TextMeshPro BreathFrequencySymbol;
    private TextMeshPro BatterySymbol;

    /* Alert */
    private GameObject TemperatureAlert;
    private GameObject SaturationAlert;
    private GameObject BloodPressureAlert;
    private GameObject HeartFrequencyAlert;
    private GameObject BreathFrequencyAlert;
    private GameObject BatteryAlert;

    /* Line Chart*/
    private WindowGraph HeartFrequencyGraph;
    private WindowGraph BreathFrequencyGraph;
    private WindowGraph SaturationGraph;
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
        this.Date = GameObject.Find("Date").GetComponent<TextMeshPro>();
        this.Hour = GameObject.Find("Hour").GetComponent<TextMeshPro>();

        /* Value components */
        this.HeartFrequencyValue = GameObject.Find("HeartFrequencyValue").GetComponent<TextMeshPro>();
        this.BreathFrequencyValue = GameObject.Find("BreathFrequencyValue").GetComponent<TextMeshPro>();
        this.SaturationValue = GameObject.Find("SaturationValue").GetComponent<TextMeshPro>();
        this.HeartFrequencyValue = GameObject.Find("HeartFrequencyValue").GetComponent<TextMeshPro>();
        this.BloodPressureValue = GameObject.Find("BloodPressureValue").GetComponent<TextMeshPro>();
        this.TemperatureValue = GameObject.Find("TemperatureValue").GetComponent<TextMeshPro>();
        this.BatteryValue = GameObject.Find("BatteryValue").GetComponent<TextMeshPro>();


        /* Symbol components */
        this.HeartFrequencySymbol = GameObject.Find("HeartFrequencySymbol").GetComponent<TextMeshPro>();
        this.BreathFrequencySymbol = GameObject.Find("BreathFrequencySymbol").GetComponent<TextMeshPro>();
        this.SaturationSymbol = GameObject.Find("SaturationSymbol").GetComponent<TextMeshPro>();
        this.HeartFrequencySymbol = GameObject.Find("HeartFrequencySymbol").GetComponent<TextMeshPro>();
        this.BloodPressureSymbol = GameObject.Find("BloodPressureSymbol").GetComponent<TextMeshPro>();
        this.TemperatureSymbol = GameObject.Find("TemperatureSymbol").GetComponent<TextMeshPro>();
        this.BatterySymbol = GameObject.Find("BatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.HeartFrequencySensorName = GameObject.Find("HeartFrequencySensorName").GetComponent<TextMeshPro>();
        this.BreathFrequencySensorName = GameObject.Find("BreathFrequencySensorName").GetComponent<TextMeshPro>();
        this.SaturationSensorName = GameObject.Find("SaturationSensorName").GetComponent<TextMeshPro>();
        this.HeartFrequencySensorName = GameObject.Find("HeartFrequencySensorName").GetComponent<TextMeshPro>();
        this.BloodPressureSensorName = GameObject.Find("BloodPressureSensorName").GetComponent<TextMeshPro>();
        this.TemperatureSensorName = GameObject.Find("TemperatureSensorName").GetComponent<TextMeshPro>();
        this.BatterySensorName = GameObject.Find("BatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.HeartFrequencyAlert = GameObject.Find("HeartFrequencyAlert");
        this.BreathFrequencyAlert = GameObject.Find("BreathFrequencyAlert");
        this.SaturationAlert = GameObject.Find("SaturationAlert");
        this.BloodPressureAlert = GameObject.Find("BloodPressureAlert");
        this.TemperatureAlert = GameObject.Find("TemperatureAlert");
        this.BatteryAlert = GameObject.Find("BatteryAlert");

        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.SaturationAlert.GetComponent<Renderer>().material = whiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material = whiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material = whiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = whiteColor;
        this.TemperatureAlert.GetComponent<Renderer>().material = whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = whiteColor;

        /* Line chart components */
        this.HeartFrequencyGraph  = GameObject.Find("HeartFrequencyLineChart").GetComponent<WindowGraph>();
        this.BreathFrequencyGraph = GameObject.Find("BreathFrequencyLineChart").GetComponent<WindowGraph>();
        this.SaturationGraph = GameObject.Find("SaturationLineChart").GetComponent<WindowGraph>();
        this.BloodPressureGraph = GameObject.Find("BloodPressureLineChart").GetComponent<WindowGraph>();
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
        this.TemperatureSymbol.text = message.temperature_sensor_value.symbol;
        this.SaturationSymbol.text = message.saturation_sensor_value.symbol;
        this.BloodPressureSymbol.text = message.blood_pressure_sensor_value.symbol;
        this.HeartFrequencySymbol.text = message.heart_frequency_sensor_value.symbol;
        this.BreathFrequencySymbol.text = message.breath_frequency_sensor_value.symbol;
        this.BatterySymbol.text = message.battery_sensor_value.symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.TemperatureValue.text = Math.Round(message.temperature_sensor_value.value, 1).ToString();
        this.SaturationValue.text = message.saturation_sensor_value.value.ToString();
        this.BloodPressureValue.text = message.blood_pressure_sensor_value.value.ToString();
        this.HeartFrequencyValue.text = message.heart_frequency_sensor_value.value.ToString();
        this.BreathFrequencyValue.text = message.breath_frequency_sensor_value.value.ToString();
        this.BatteryValue.text = message.battery_sensor_value.value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.TemperatureSensorName.text = message.temperature_sensor_name;
        this.SaturationSensorName.text = message.saturation_sensor_name;
        this.BloodPressureSensorName.text = message.blood_pressure_sensor_name;
        this.HeartFrequencySensorName.text = message.heart_frequency_sensor_name;
        this.BreathFrequencySensorName.text = message.breath_frequency_sensor_name;
        this.BatterySensorName.text = message.battery_sensor_name;
    }

    private void UpdateSensorAlerts(Message message)
    {
        Material redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.TemperatureAlert.GetComponent<Renderer>().material = message.temperature_alarm ? redColor : whiteColor;
        this.SaturationAlert.GetComponent<Renderer>().material = message.saturation_alarm ? redColor : whiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material = message.blood_pressure_alarm ? redColor : whiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material = message.heart_frequency_alarm ? redColor : whiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = message.breath_frequency_alarm ? redColor : whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = message.battery_alarm ? redColor : whiteColor;
    }

    private void UpdateLineCharts(Message message)
    {
        Color HearthFrequencyColor = SplitColor((string)message.heart_frequency_graph_color);
        this.HeartFrequencyGraph.AddPoint((float)message.heart_frequency_sensor_value.value,
                                          (float)message.heart_frequency_sensor_value.min_value,
                                          (float)message.heart_frequency_sensor_value.max_value,
                                          HearthFrequencyColor);

        Color BreathFrequencyColor = SplitColor((string)message.breath_frequency_graph_color);
        this.BreathFrequencyGraph.AddPoint((float)message.breath_frequency_sensor_value.value,
                                           (float)message.breath_frequency_sensor_value.min_value,
                                           (float)message.breath_frequency_sensor_value.max_value,
                                           BreathFrequencyColor);

        Color SaturationColor = SplitColor((string)message.saturation_graph_color);
        this.SaturationGraph.AddPoint((float)message.saturation_sensor_value.value,
                                      (float)message.saturation_sensor_value.min_value,
                                      (float)message.saturation_sensor_value.max_value,
                                      SaturationColor);

        Color BloodPressureColor = SplitColor((string)message.blood_pressure_graph_color);
        this.BloodPressureGraph.AddPoint((float)message.blood_pressure_sensor_value.value,
                                         (float)message.blood_pressure_sensor_value.min_value,
                                         (float)message.blood_pressure_sensor_value.max_value,
                                         BloodPressureColor);
    }
    private Color SplitColor(string color)
    {
        int channelR = Convert.ToInt32(color.Split(',')[0]);
        int channelG = Convert.ToInt32(color.Split(',')[1]);
        int channelB = Convert.ToInt32(color.Split(',')[2]);
        return new Color(channelR, channelG, channelB, 250f);
    }
}
