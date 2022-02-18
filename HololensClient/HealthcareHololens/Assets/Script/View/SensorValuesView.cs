using System;
using TMPro;
using UnityEngine;

public class SensorValuesView : VitalSignsMonitorElement
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
        this.Date = GameObject.Find("DetailValueDate").GetComponent<TextMeshPro>();
        this.Hour = GameObject.Find("DetailValueHour").GetComponent<TextMeshPro>();

        /* Value components */
        this.HeartFrequencyValue = GameObject.Find("DetailValueHeartFrequencyValue").GetComponent<TextMeshPro>();
        this.BreathFrequencyValue = GameObject.Find("DetailValueBreathFrequencyValue").GetComponent<TextMeshPro>();
        this.SaturationValue = GameObject.Find("DetailValueSaturationValue").GetComponent<TextMeshPro>();
        this.BloodPressureValue = GameObject.Find("DetailValueBloodPressureValue").GetComponent<TextMeshPro>();
        this.TemperatureValue = GameObject.Find("DetailValueTemperatureValue").GetComponent<TextMeshPro>();
        this.BatteryValue = GameObject.Find("DetailValueBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this.HeartFrequencySymbol = GameObject.Find("DetailValueHeartFrequencySymbol").GetComponent<TextMeshPro>();
        this.BreathFrequencySymbol = GameObject.Find("DetailValueBreathFrequencySymbol").GetComponent<TextMeshPro>();
        this.SaturationSymbol = GameObject.Find("DetailValueSaturationSymbol").GetComponent<TextMeshPro>();
        this.BloodPressureSymbol = GameObject.Find("DetailValueBloodPressureSymbol").GetComponent<TextMeshPro>();
        this.TemperatureSymbol = GameObject.Find("DetailValueTemperatureSymbol").GetComponent<TextMeshPro>();
        this.BatterySymbol = GameObject.Find("DetailValueBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.HeartFrequencySensorName = GameObject.Find("DetailValueHeartFrequencySensorName").GetComponent<TextMeshPro>();
        this.BreathFrequencySensorName = GameObject.Find("DetailValueBreathFrequencySensorName").GetComponent<TextMeshPro>();
        this.SaturationSensorName = GameObject.Find("DetailValueSaturationSensorName").GetComponent<TextMeshPro>();
        this.BloodPressureSensorName = GameObject.Find("DetailValueBloodPressureSensorName").GetComponent<TextMeshPro>();
        this.TemperatureSensorName = GameObject.Find("DetailValueTemperatureSensorName").GetComponent<TextMeshPro>();
        this.BatterySensorName = GameObject.Find("DetailValueBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.HeartFrequencyAlert = GameObject.Find("DetailValueHeartFrequencyAlert");
        this.BreathFrequencyAlert = GameObject.Find("DetailValueBreathFrequencyAlert");
        this.SaturationAlert = GameObject.Find("DetailValueSaturationAlert");
        this.BloodPressureAlert = GameObject.Find("DetailValueBloodPressureAlert");
        this.TemperatureAlert = GameObject.Find("DetailValueTemperatureAlert");
        this.BatteryAlert = GameObject.Find("DetailValueBatteryAlert");

        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.SaturationAlert.GetComponent<Renderer>().material = whiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material = whiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material = whiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = whiteColor;
        this.TemperatureAlert.GetComponent<Renderer>().material = whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = whiteColor;
    }

    public void UpdateView(Message message)
    {
        try
        {
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
        this.TemperatureSymbol.text = message.TemperatureSensorValue.Symbol;
        this.SaturationSymbol.text = message.SaturationSensorValue.Symbol;
        this.BloodPressureSymbol.text = message.BloodPressureSensorValue.Symbol;
        this.HeartFrequencySymbol.text = message.HeartFrequencySensorValue.Symbol;
        this.BreathFrequencySymbol.text = message.BreathFrequencySensorValue.Symbol;
        this.BatterySymbol.text = message.BatterySensorValue.Symbol;
    }

    private void UpdateSensorValues(Message message)
    {
        this.TemperatureValue.text = Math.Round(message.TemperatureSensorValue.Value, 1).ToString();

        this.SaturationValue.text = message.SaturationSensorValue.Value.ToString();
        this.SaturationValue.color = SplitColor((string)message.SaturationGraphColor);

        this.BloodPressureValue.text = message.BloodPressureSensorValue.Value.ToString();
        this.BloodPressureValue.color = SplitColor((string)message.BloodPressureGraphColor);

        this.HeartFrequencyValue.text = message.HeartFrequencySensorValue.Value.ToString();
        this.HeartFrequencyValue.color = SplitColor((string)message.HeartFrequencyGraphColor);

        this.BreathFrequencyValue.text = message.BreathFrequencySensorValue.Value.ToString();
        this.BreathFrequencyValue.color = SplitColor((string)message.BreathFrequencyGraphColor);

        this.BatteryValue.text = message.BatterySensorValue.Value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.TemperatureSensorName.text = message.TemperatureSensorName;
        this.SaturationSensorName.text = message.SaturationSensorName;
        this.BloodPressureSensorName.text = message.BloodPressureSensorName;
        this.HeartFrequencySensorName.text = message.HeartFrequencySensorName;
        this.BreathFrequencySensorName.text = message.BreathFrequencySensorName;
        this.BatterySensorName.text = message.BatterySensorName;
    }

    private void UpdateSensorAlerts(Message message)
    {
        Material redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.TemperatureAlert.GetComponent<Renderer>().material = message.TemperatureSensorAlarm ? redColor : whiteColor;
        this.SaturationAlert.GetComponent<Renderer>().material = message.SaturationSensorAlarm ? redColor : whiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material = message.BloodPressureSensorAlarm ? redColor : whiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material = message.HeartFrequencySensorAlarm ? redColor : whiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = message.BreathFrequencySensorAlarm ? redColor : whiteColor;
        this.BatteryAlert.GetComponent<Renderer>().material = message.BatterySensorAlarm ? redColor : whiteColor;
    }

    private Color SplitColor(string color)
    {
        int channelR = Convert.ToInt32(color.Split(',')[0]);
        int channelG = Convert.ToInt32(color.Split(',')[1]);
        int channelB = Convert.ToInt32(color.Split(',')[2]);
        return new Color(channelR, channelG, channelB, 250f);
    }
}
