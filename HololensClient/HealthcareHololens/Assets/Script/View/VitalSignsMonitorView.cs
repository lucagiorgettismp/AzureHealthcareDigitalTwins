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

    public void UpdateView(Message message)
    {
        try
        {
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
        //TemperatureSymbol.text = message.TemperatureSensorValue.Symbol;
        SaturationSymbol.text = message.SaturationSensorValue.Symbol;
        BloodPressureSymbol.text = message.BloodPressureSensorValue.Symbol;
        HeartFrequencySymbol.text = message.HeartFrequencySensorValue.Symbol;
        BreathFrequencySymbol.text = message.BreathFrequencySensorValue.Symbol;
        //BatterySymbol.text = message.BatterySensorValue.Symbol;
    }

    private void UpdateSensorValues(Message message) {
        //TemperatureValue.text = Math.Round(message.TemperatureSensorValue.Value, 1).ToString();
        SaturationValue.text =  message.SaturationSensorValue.Value.ToString();
        BloodPressureValue.text = message.BloodPressureSensorValue.Value.ToString();
        HeartFrequencyValue.text = message.HeartFrequencySensorValue.Value.ToString();
        BreathFrequencyValue.text = message.BreathFrequencySensorValue.Value.ToString();
        //BatteryValue.text = message.BatterySensorValue.Value.ToString();
    }

    private void UpdateSensorNames(Message message)
    {
        //TemperatureSensorName.text = message.TemperatureSensorName;
        SaturationSensorName.text = message.SaturationSensorName;
        BloodPressureSensorName.text = message.BloodPressureSensorName;
        HeartFrequencySensorName.text = message.HeartFrequencySensorName;
        BreathFrequencySensorName.text = message.BreathFrequencySensorName;
        //BatterySensorName.text = message.BatterySensorName;
    }
    private void UpdateSensorAlerts(Message message) {

        Material redColor = Resources.Load("Materials/RedColor", typeof(Material)) as Material;
        Material whiteColor = Resources.Load("Materials/WhiteColor", typeof(Material)) as Material;

        //TemperatureAlert.GetComponent<Renderer>().material = message.TemperatureSensorAlarm ? redColor : whiteColor;
        SaturationAlert.GetComponent<Renderer>().material = message.SaturationSensorAlarm ? redColor : whiteColor;
        BloodPressureAlert.GetComponent<Renderer>().material = message.BloodPressureSensorAlarm ? redColor : whiteColor;
        HeartFrequencyAlert.GetComponent<Renderer>().material = message.HeartFrequencySensorAlarm ? redColor : whiteColor;
        BreathFrequencyAlert.GetComponent<Renderer>().material = message.BreathFrequencySensorAlarm ? redColor : whiteColor;
        //BatteryAlert.GetComponent<Renderer>().material = message.BatterySensorAlarm ? redColor : whiteColor;
    }
}
