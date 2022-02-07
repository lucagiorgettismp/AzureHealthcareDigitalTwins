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
        connection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            OnMessageReceived?.Invoke(new Message
            {
                UserName = user,
                Text = message,
            });
        });
        await StartConnectionAsync();
    }

    public async Task SendMessageAsync(Message message)
    {
        try
        {
            await connection.InvokeAsync("SendMessage", message.UserName, message.Text);
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.LogError($"Error {ex.Message}");
        }
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