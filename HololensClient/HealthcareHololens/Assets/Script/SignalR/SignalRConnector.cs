using System;
using System.Threading.Tasks;
using UnityEngine;
using Microsoft.AspNetCore.SignalR.Client;

public class SignalRConnector
{
    public Action<Message> OnMessageReceived;
    private HubConnection connection;

    public async Task InitAsync()
    {
        string host = "https://healthcareiothubtodt.azurewebsites.net/api";

        connection = new HubConnectionBuilder()
            .WithUrl(host)
            .Build();

        connection.On<Message>("newMessage", (message) =>
        {
            OnMessageReceived?.Invoke(message);
        });

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
        }
    }
}