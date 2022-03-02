using System;
using System.Threading.Tasks;
using UnityEngine;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;

public class SignalRConnector
{
    private HubConnection connection;
    private Callback callback;

    public SignalRConnector(Callback callback)
    {
        this.callback = callback;
    }

    public async Task InitAsync()
    {
        string host = "https://healthcareiothubtodt.azurewebsites.net/api";

        try
        {
            connection = new HubConnectionBuilder()
                .WithUrl(host)
                .Build();

            connection.On<Message>("PGNLNZ97M18G479M", (message) =>
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