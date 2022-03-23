using System;
using UnityEngine;

public class VitalSignsMonitorModel
{
    private SignalRConnector connector;
    private readonly VitalSignsMonitorController controller;

    public VitalSignsMonitorModel(VitalSignsMonitorController controller)
    {
        this.controller = controller;
    }

    public async void Init(string deviceId)
    {
        try
        {
            connector = new SignalRConnector(new ConnectorCallback(controller), deviceId);
            await connector.InitAsync();
        }catch(Exception e)
        {
            Debug.LogError("Error model: "+ e.Message);
        }
    }
}

public interface ICallback {
    public void OnMessageReceived(Message message);  
}

public class ConnectorCallback : ICallback
{
    private readonly VitalSignsMonitorController controller;

    public ConnectorCallback(VitalSignsMonitorController controller)
    {
        this.controller = controller;
    }

    public void OnMessageReceived(Message message)
    {
        this.controller.OnDataReceived(message);
    }
}
