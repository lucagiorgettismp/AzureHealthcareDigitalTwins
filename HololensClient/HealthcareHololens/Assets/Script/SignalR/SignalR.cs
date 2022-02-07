using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.AspNetCore.SignalR.Client;

public class SignalR : MonoBehaviour
{
    public Text ReceivedText;
    private SignalRConnector connector;

    public async Task Start()
    {
        connector = new SignalRConnector();
        connector.OnMessageReceived += UpdateReceivedMessages;

        await connector.InitAsync();
    }

    private void UpdateReceivedMessages(Message newMessage)
    {
        var lastMessages = this.ReceivedText.text;
        if (string.IsNullOrEmpty(lastMessages) == false)
        {
            lastMessages += "\n";
        }

        lastMessages += $"Temperature:\nValue: {newMessage.temperature_value} Alram: {newMessage.temperature_alarm}";
        this.ReceivedText.text = lastMessages;
    }
}
