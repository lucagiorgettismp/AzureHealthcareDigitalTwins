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
                .AddNewtonsoftJsonProtocol()
                .Build();

            connection.On<Message>("newMessage", (message) =>
            {
                this.callback.OnMessageReceived(message);
            });
        }
        catch (Exception e)
        {
            this.callback.OnError("InitAsync error: " + e.Message + "\n\n" + e.StackTrace);
        }


        await StartConnectionAsync();
    }

    private async Task StartConnectionAsync()
    {
        try
        {
            await connection.StartAsync();
        }
        catch (Exception ex)
        {
            Debug.LogError($"Error: {ex.Message}");
            this.callback.OnError("StartConnectionAsync error: " + ex.Message + "\n\n" + ex.StackTrace);
        }
    }
}