using UnityEngine;
using TMPro;
using System;

public class VitalSignsMonitorView : VitalSignsMonitorElement
{
    /* Value */
    public TextMeshPro TemperatureValue;
    public TextMeshPro SaturationValue;
    public TextMeshPro BloodPressureValue;
    public TextMeshPro HeartFrequencyValue;
    public TextMeshPro BreathFrequencyValue;
    public TextMeshPro BatteryValue;

    /* Sensor name */
    public TextMeshPro TemperatureSensorName;
    public TextMeshPro SaturationSensorName;
    public TextMeshPro BloodPressureSensorName;
    public TextMeshPro HeartFrequencySensorName;
    public TextMeshPro BreathFrequencySensorName;
    public TextMeshPro BatterySensorName;

    /* Symbol */
    public TextMeshPro TemperatureSymbol;
    public TextMeshPro SaturationSymbol;
    public TextMeshPro BloodPressureSymbol;
    public TextMeshPro HeartFrequencySymbol;
    public TextMeshPro BreathFrequencySymbol;
    public TextMeshPro BatterySymbol;

    /* Alert */
    public GameObject TemperatureAlert;
    public GameObject SaturationAlert;
    public GameObject BloodPressureAlert;
    public GameObject HeartFrequencyAlert;
    public GameObject BreathFrequencyAlert;
    public GameObject BatteryAlert;

    /* Line Chart*/
    public DD_DataDiagram HeartFrequencyDataDiagram;
    public DD_DataDiagram BreathFrequencyDataDiagram;
    public DD_DataDiagram SaturationDataDiagram;
    public DD_DataDiagram BloodPressureDataDiagram;

    private GameObject HeartLine;
    private GameObject BreathLine;
    private GameObject BloodPressureLine;
    private GameObject SaturationLine;

    public void Start()
    {
        this.HeartLine = this.HeartFrequencyDataDiagram.AddLine("HeartFrequency", Color.green);
        this.BreathLine = this.BreathFrequencyDataDiagram.AddLine("BreathFrequency", Color.green);
        this.SaturationLine = this.SaturationDataDiagram.AddLine("Saturation", Color.red);
        this.BloodPressureLine = this.BloodPressureDataDiagram.AddLine("BloodPressure", Color.yellow);
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
        //this.TemperatureSymbol.text = message.TemperatureSensorValue.Symbol;
        this.SaturationSymbol.text = message.SaturationSensorValue.Symbol;
        this.BloodPressureSymbol.text = message.BloodPressureSensorValue.Symbol;
        this.HeartFrequencySymbol.text = message.HeartFrequencySensorValue.Symbol;
        this.BreathFrequencySymbol.text = message.BreathFrequencySensorValue.Symbol;
        //this.BatterySymbol.text = message.BatterySensorValue.Symbol;
    }

    private void UpdateSensorValues(Message message) {
        //this.TemperatureValue.text = Math.Round(message.TemperatureSensorValue.Value, 1).ToString();
        this.SaturationValue.text =  message.SaturationSensorValue.Value.ToString();
        this.BloodPressureValue.text = message.BloodPressureSensorValue.Value.ToString();
        this.HeartFrequencyValue.text = message.HeartFrequencySensorValue.Value.ToString();
        this.BreathFrequencyValue.text = message.BreathFrequencySensorValue.Value.ToString();
        //this.BatteryValue.text = message.BatterySensorValue.Value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        //this.TemperatureSensorName.text = message.TemperatureSensorName;
        this.SaturationSensorName.text = message.SaturationSensorName;
        this.BloodPressureSensorName.text = message.BloodPressureSensorName;
        this.HeartFrequencySensorName.text = message.HeartFrequencySensorName;
        this.BreathFrequencySensorName.text = message.BreathFrequencySensorName;
        //this.BatterySensorName.text = message.BatterySensorName;
    }
    private void UpdateSensorAlerts(Message message) {

        Material redColor = Resources.Load("Materials/RedColor", typeof(Material)) as Material;
        Material whiteColor = Resources.Load("Materials/WhiteColor", typeof(Material)) as Material;

        //this.TemperatureAlert.GetComponent<Renderer>().material = message.TemperatureSensorAlarm ? redColor : whiteColor;
        this.SaturationAlert.GetComponent<Renderer>().material = message.SaturationSensorAlarm ? redColor : whiteColor;
        this.BloodPressureAlert.GetComponent<Renderer>().material = message.BloodPressureSensorAlarm ? redColor : whiteColor;
        this.HeartFrequencyAlert.GetComponent<Renderer>().material = message.HeartFrequencySensorAlarm ? redColor : whiteColor;
        this.BreathFrequencyAlert.GetComponent<Renderer>().material = message.BreathFrequencySensorAlarm ? redColor : whiteColor;
        //this.BatteryAlert.GetComponent<Renderer>().material = message.BatterySensorAlarm ? redColor : whiteColor;
    }

    private void UpdateLineCharts(Message message)
    {
        try
        {
            this.HeartFrequencyDataDiagram.InputPoint(this.HeartLine, new Vector2(1, 0));
            this.BreathFrequencyDataDiagram.InputPoint(this.BreathLine, new Vector2(1, (float)message.BreathFrequencySensorValue.Value));
            this.SaturationDataDiagram.InputPoint(this.SaturationLine, new Vector2(1, (float)message.SaturationSensorValue.Value));
            this.BloodPressureDataDiagram.InputPoint(this.BloodPressureLine, new Vector2(1, (float)message.BloodPressureSensorValue.Value));

        }catch(Exception e)
        {
            Debug.LogError("Error update charts: " + e.Message);
        }
    }
}
