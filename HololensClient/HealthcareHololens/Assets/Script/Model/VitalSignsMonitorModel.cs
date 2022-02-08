using UnityEngine;

public class VitalSignsMonitorModel : VitalSignsMonitorElement
{
    private SignalRConnector connector;

    public async void Start()
    {
        connector = new SignalRConnector();
        connector.OnMessageReceived += app.Controller.OnDataReceived;
        await connector.InitAsync();
    }
}
