using UnityEngine;
using TMPro;
using System;

public class VitalSignsMonitorView : VitalSignsMonitorElement
{
    public TextMeshProUGUI TemperatureValue;
    public TextMeshProUGUI SaturationValue;
    public TextMeshProUGUI BloodPressureValue;
    public TextMeshProUGUI HeartFrequencyValue;
    public TextMeshProUGUI BreathFrequencyValue;
    public TextMeshProUGUI BatteryValue;

    public void UpdateView(Message message)
    {
        try
        {
            TemperatureValue.text = message.TemperatureSensorName + ": " + Math.Round(message.TemperatureSensorValue.Value, 1);
            SaturationValue.text = message.SaturationSensorName + ": " + message.SaturationSensorValue.Value;
            BloodPressureValue.text = message.BloodPressureSensorName + ": " + message.BloodPressureSensorValue.Value;
            HeartFrequencyValue.text = message.HeartFrequencySensorName + ": " + message.HeartFrequencySensorValue.Value;
            BreathFrequencyValue.text = message.BreathFrequencySensorName + ": " + message.BreathFrequencySensorValue.Value;
            BatteryValue.text = message.BatterySensorName + ": " + message.BatterySensorValue.Value;
        }catch(Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }
}
