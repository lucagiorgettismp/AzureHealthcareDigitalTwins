using System;
using UnityEngine;

public class VitalSignsMonitorModel
{
    private SignalRConnector _connector;
    private readonly VitalSignsMonitorController _controller;

    public VitalSignsMonitorModel(VitalSignsMonitorController controller)
    {
        this._controller = controller;
    }

    public async void Init(string deviceId)
    {
        try
        {
            _connector = new SignalRConnector((message) => this._controller.OnDataReceived(message), deviceId);
            await _connector.InitAsync();
        }catch(Exception e)
        {
            Debug.LogError("Error model: "+ e.Message);
        }
    }
}