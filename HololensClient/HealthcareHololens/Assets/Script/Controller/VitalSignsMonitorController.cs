using UnityEngine;

public class VitalSignsMonitorController : VitalSignsMonitorElement
{
    public void OnDataReceived(Message message) {
        Debug.Log("Message received: " + message.TemperatureValue);
        App.View.UpdateView(message);
    }
}
