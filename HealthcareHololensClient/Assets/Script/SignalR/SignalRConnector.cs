using System;
using System.Threading.Tasks;
using UnityEngine;
using Microsoft.AspNetCore.SignalR.Client;

public class SignalRConnector
{
    private HubConnection _hubConnection;
    private readonly string _deviceId = null;
    private readonly Action<Message> _onMessageReceived;

    public SignalRConnector(Action<Message> onMessageReceived, string deviceId)
    {
        this._deviceId = deviceId;
        this._onMessageReceived = onMessageReceived;
    }

    public async Task InitAsync()
    {
        if (this._deviceId != null)
        {
            string host = "https://healthcareiothubtodt.azurewebsites.net/api";

            try
            {
                _hubConnection = new HubConnectionBuilder()
                    .WithUrl(host)
                    .Build();

                _hubConnection.On<Message>(this._deviceId, (message) =>
                    {
                        this._onMessageReceived(message);
                    });
            }
            catch (Exception e)
            {
                Debug.LogError("Error in connection signalR: " + e.Message);
            }

            await _hubConnection.StartAsync();
        }
    }
}