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

    public void UpdateView(Message message)
    {
        try
        {
            Debug.Log("Update text view");
            TemperatureValue.text = Math.Round(message.temperature_value, 2).ToString();
        }catch(Exception e)
        {
            Debug.LogError("Error: "+e.Message);
        }
    }
}
