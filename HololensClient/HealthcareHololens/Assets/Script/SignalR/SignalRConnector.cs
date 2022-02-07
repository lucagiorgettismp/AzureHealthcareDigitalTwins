using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Microsoft.AspNetCore.SignalR.Client;

public class SignalRConnector
{
    public Action<Message> OnMessageReceived;
    private HubConnection connection;

    public async Task InitAsync()
    {
        string host = "http://localhost:3000";

        connection = new HubConnectionBuilder().WithUrl(host).Build();
        connection.On<Message>("newMessage", (message) =>
        {
            OnMessageReceived?.Invoke(new Message
            {
              temperature_value = message.temperature_value,
              temperature_alarm = message.temperature_alarm
            });           
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
            UnityEngine.Debug.LogError($"Error {ex.Message}");
        }
    }
}