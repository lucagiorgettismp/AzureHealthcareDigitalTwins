using System;
using UnityEngine;

public class VitalSignsMonitorModel : BaseApplicationPanel
{
    private SignalRConnector connector;

    public async void Start()
    {
        try
        {
            connector = new SignalRConnector(new Callback(App.Controller));
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

public class Callback : ICallback
{
    VitalSignsMonitorController controller;
    public Callback(VitalSignsMonitorController controller)
    {
        this.controller = controller;
        this.controller.OnError("Callback - Setup controller into callback");
    }

    public void OnMessageReceived(Message message)
    {
        this.controller.OnDataReceived(message);
        this.controller.OnError("Callback - Message successfully received");
    }

    internal void OnError(string message)
    {
        this.controller.OnError("Callback error:" + message);
    }
}
