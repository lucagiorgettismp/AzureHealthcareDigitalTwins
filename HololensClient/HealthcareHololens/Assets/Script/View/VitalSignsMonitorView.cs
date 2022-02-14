using UnityEngine;
using TMPro;
using System;

public class VitalSignsMonitorView : VitalSignsMonitorElement
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
    private DD_DataDiagram HeartFrequencyDataDiagram;
    private DD_DataDiagram BreathFrequencyDataDiagram;
    private DD_DataDiagram SaturationDataDiagram;
    private DD_DataDiagram BloodPressureDataDiagram;

    private GameObject HeartLine;
    private GameObject BreathLine;
    private GameObject BloodPressureLine;
    private GameObject SaturationLine;

    /* Colors */
    const string RED_COLOR = "Materials/RedColor";
    const string WHITE_COLOR = "Materials/WhiteColor";

    public void Start()
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
        this.HeartFrequencyValue    = GameObject.Find("HeartFrequencyValue").GetComponent<TextMeshPro>();
        this.BreathFrequencyValue   = GameObject.Find("BreathFrequencyValue").GetComponent<TextMeshPro>();
        this.SaturationValue        = GameObject.Find("SaturationValue").GetComponent<TextMeshPro>();
        this.HeartFrequencyValue    = GameObject.Find("HeartFrequencyValue").GetComponent<TextMeshPro>();
        this.BloodPressureValue     = GameObject.Find("BloodPressureValue").GetComponent<TextMeshPro>();
        this.TemperatureValue       = GameObject.Find("TemperatureValue").GetComponent<TextMeshPro>();
        //this.BatteryValue         = GameObject.Find("BatteryValue").GetComponent<TextMeshPro>();


        /* Symbol components */
        this.HeartFrequencySymbol   = GameObject.Find("HeartFrequencySymbol").GetComponent<TextMeshPro>();
        this.BreathFrequencySymbol  = GameObject.Find("BreathFrequencySymbol").GetComponent<TextMeshPro>();
        this.SaturationSymbol       = GameObject.Find("SaturationSymbol").GetComponent<TextMeshPro>();
        this.HeartFrequencySymbol   = GameObject.Find("HeartFrequencySymbol").GetComponent<TextMeshPro>();
        this.BloodPressureSymbol    = GameObject.Find("BloodPressureSymbol").GetComponent<TextMeshPro>();
        this.TemperatureSymbol      = GameObject.Find("TemperatureSymbol").GetComponent<TextMeshPro>();
        //this.BatterySymbol        = GameObject.Find("BatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this.HeartFrequencySensorName   = GameObject.Find("HeartFrequencySensorName").GetComponent<TextMeshPro>();
        this.BreathFrequencySensorName  = GameObject.Find("BreathFrequencySensorName").GetComponent<TextMeshPro>();
        this.SaturationSensorName       = GameObject.Find("SaturationSensorName").GetComponent<TextMeshPro>();
        this.HeartFrequencySensorName   = GameObject.Find("HeartFrequencySensorName").GetComponent<TextMeshPro>();
        this.BloodPressureSensorName    = GameObject.Find("BloodPressureSensorName").GetComponent<TextMeshPro>();
        this.TemperatureSensorName      = GameObject.Find("TemperatureSensorName").GetComponent<TextMeshPro>();
        //this.BatterySensorName        = GameObject.Find("BatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this.HeartFrequencyAlert    = GameObject.Find("HeartFrequencyAlert");
        this.BreathFrequencyAlert   = GameObject.Find("BreathFrequencyAlert");
        this.SaturationAlert        = GameObject.Find("SaturationAlert");
        this.BloodPressureAlert     = GameObject.Find("BloodPressureAlert");
        this.TemperatureAlert       = GameObject.Find("TemperatureAlert");
        //this.BatteryAlert         = GameObject.Find("BatteryAlert");

        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;
        this.SaturationAlert.GetComponent<Renderer>().material = whiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material = whiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material = whiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = whiteColor;
        this.TemperatureAlert.GetComponent<Renderer>().material = whiteColor;
        //this.BatteryAlert.GetComponent<Renderer>().material = whiteColor;

        /* Line chart components */

        this.HeartFrequencyDataDiagram  = GameObject.Find("HeartFrequencyLineChart").GetComponent<DD_DataDiagram>();
        this.BreathFrequencyDataDiagram = GameObject.Find("BreathFrequencyLineChart").GetComponent<DD_DataDiagram>();
        this.SaturationDataDiagram      = GameObject.Find("SaturationLineChart").GetComponent<DD_DataDiagram>();
        this.BloodPressureDataDiagram   = GameObject.Find("BloodPressureLineChart").GetComponent<DD_DataDiagram>();

        this.HeartLine          = this.HeartFrequencyDataDiagram.AddLine("HeartFrequency", Color.green);
        this.BreathLine         = this.BreathFrequencyDataDiagram.AddLine("BreathFrequency", Color.green);
        this.SaturationLine     = this.SaturationDataDiagram.AddLine("Saturation", Color.red);
        this.BloodPressureLine  = this.BloodPressureDataDiagram.AddLine("BloodPressure", Color.yellow);
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

    private void UpdateSensorSymbols(Message message) {
        this.TemperatureSymbol.text     = message.TemperatureSensorValue.Symbol;
        this.SaturationSymbol.text      = message.SaturationSensorValue.Symbol;
        this.BloodPressureSymbol.text   = message.BloodPressureSensorValue.Symbol;
        this.HeartFrequencySymbol.text  = message.HeartFrequencySensorValue.Symbol;
        this.BreathFrequencySymbol.text = message.BreathFrequencySensorValue.Symbol;
        //this.BatterySymbol.text       = message.BatterySensorValue.Symbol;
    }

    private void UpdateSensorValues(Message message) {
        this.TemperatureValue.text      = Math.Round(message.TemperatureSensorValue.Value, 1).ToString();
        this.SaturationValue.text       =  message.SaturationSensorValue.Value.ToString();
        this.BloodPressureValue.text    = message.BloodPressureSensorValue.Value.ToString();
        this.HeartFrequencyValue.text   = message.HeartFrequencySensorValue.Value.ToString();
        this.BreathFrequencyValue.text  = message.BreathFrequencySensorValue.Value.ToString();
        //this.BatteryValue.text        = message.BatterySensorValue.Value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        this.TemperatureSensorName.text     = message.TemperatureSensorName;
        this.SaturationSensorName.text      = message.SaturationSensorName;
        this.BloodPressureSensorName.text   = message.BloodPressureSensorName;
        this.HeartFrequencySensorName.text  = message.HeartFrequencySensorName;
        this.BreathFrequencySensorName.text = message.BreathFrequencySensorName;
        //this.BatterySensorName.text       = message.BatterySensorName;
    }
    private void UpdateSensorAlerts(Message message) {

        Material redColor = Resources.Load(RED_COLOR, typeof(Material)) as Material;
        Material whiteColor = Resources.Load(WHITE_COLOR, typeof(Material)) as Material;

        this.TemperatureAlert.GetComponent<Renderer>().material     = message.TemperatureSensorAlarm ? redColor : whiteColor;
        this.SaturationAlert.GetComponent<Renderer>().material      = message.SaturationSensorAlarm ? redColor : whiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material   = message.BloodPressureSensorAlarm ? redColor : whiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material  = message.HeartFrequencySensorAlarm ? redColor : whiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = message.BreathFrequencySensorAlarm ? redColor : whiteColor;
        //this.BatteryAlert.GetComponent<Renderer>().material       = message.BatterySensorAlarm ? redColor : whiteColor;
    }

    private void UpdateLineCharts(Message message)
    {
        try
        {
            this.HeartFrequencyDataDiagram.InputPoint(this.HeartLine, new Vector2(1, (float)message.HeartFrequencySensorValue.Value));
            this.BreathFrequencyDataDiagram.InputPoint(this.BreathLine, new Vector2(1, (float)message.BreathFrequencySensorValue.Value));
            this.SaturationDataDiagram.InputPoint(this.SaturationLine, new Vector2(1, (float)message.SaturationSensorValue.Value));
            this.BloodPressureDataDiagram.InputPoint(this.BloodPressureLine, new Vector2(1, (float)message.BloodPressureSensorValue.Value));
        }
        catch (Exception e)
        {
            Debug.LogError("Error update charts: " + e.Message);
        }
    }
}
