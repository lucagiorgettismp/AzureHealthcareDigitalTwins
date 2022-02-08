using UnityEngine;

public class VitalSignsMonitorController : VitalSignsMonitorElement
{
    public void OnDataReceived(Message message) {
        Debug.Log("Message received: " + message.temperature_value);
        app.View.UpdateView(message);
    }
}
