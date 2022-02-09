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
            TemperatureValue.text = "Temp: " + Math.Round(message.TemperatureValue, 1).ToString();
            SaturationValue.text = "Sat: " + message.SaturationValue.ToString();
            BloodPressureValue.text = "Blood: " + message.BloodPressureValue.ToString();
            HeartFrequencyValue.text = "Heart: " + message.HeartFrequencyValue.ToString();
            BreathFrequencyValue.text = "Breath: " + message.BreathFrequencyValue.ToString();
            BatteryValue.text = "Battery: " + message.BatteryValue.ToString();
        }catch(Exception e)
        {
            Debug.LogError("Error: "+e.Message);
        }
    }
}
