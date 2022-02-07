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
    public InputField MessageInput;
    public Button SendButton;
    private SignalRConnector connector;

    public async Task Start()
    {
        connector = new SignalRConnector();
        connector.OnMessageReceived += UpdateReceivedMessages;

        await connector.InitAsync();
        SendButton.onClick.AddListener(SendMessage);
    }

    private void UpdateReceivedMessages(Message newMessage)
    {
        var lastMessages = this.ReceivedText.text;
        if (string.IsNullOrEmpty(lastMessages) == false)
        {
            lastMessages += "\n";
        }
        lastMessages += $"User:{newMessage.UserName} Message:{newMessage.Text}";
        this.ReceivedText.text = lastMessages;
    }

    private async void SendMessage()
    {
        await connector.SendMessageAsync(new Message
        {
            UserName = "Example",
            Text = MessageInput.text,
        });
    }
}
