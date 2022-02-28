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

            connection.On<Message>("PGNLNZ97M18G479M", (message) =>
                {
                    this.callback.OnMessageReceived(message);
                    this.callback.OnLog("Connector - new message: " + message.ToString());
                });
        }
        catch (Exception e)
        {
            this.callback.OnLog("InitAsync error: " + e.Message + "\n\n" + e.StackTrace);
        }

       await StartConnectionAsync();
    }

    private async Task StartConnectionAsync()
    {
        try
        {
            this.callback.OnLog($"StartConnectionAsync - started");
            await connection.StartAsync();
        }
        catch (Exception ex)
        {
            Debug.LogError($"Error: {ex.Message}");
            this.callback.OnLog("StartConnectionAsync error: " + ex.Message + "\n\n" + ex.StackTrace);
        } finally
        {
            this.callback.OnLog($"StartConnectionAsync - connectionId: {connection.ConnectionId}, connState: {connection.State}");

        }
    }
}