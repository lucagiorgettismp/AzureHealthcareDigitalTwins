using System;
using System.Threading.Tasks;
using UnityEngine;
using Microsoft.AspNetCore.SignalR.Client;

public class SignalRConnector
{
    private HubConnection connection;
    private ConnectorCallback callback;
    private string deviceId = null;

    public SignalRConnector(ConnectorCallback callback, string deviceId)
    {
        this.callback = callback;
        this.deviceId = deviceId;
    }

    public async Task InitAsync()
    {
        if (this.deviceId != null)
        {
            string host = "https://healthcareiothubtodt.azurewebsites.net/api";

            try
            {
                connection = new HubConnectionBuilder()
                    .WithUrl(host)
                    .Build();

                connection.On<Message>(this.deviceId, (message) =>
                    {
                        this.callback.OnMessageReceived(message);
                    });
            }
            catch (Exception e)
            {
                Debug.LogError("Error in connection signalR: " + e.Message);
            }

            await connection.StartAsync();
        }
    }
}