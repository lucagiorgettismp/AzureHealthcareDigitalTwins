namespace AppFunctions
{
    using AppFunctions.Model.SignalREventPayload;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Azure.EventGrid.Models;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.EventGrid;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Azure.WebJobs.Extensions.SignalRService;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SignalRFunction
    {
        public static double temperature;

        [FunctionName("negotiate")]
        public static SignalRConnectionInfo GetSignalRInfo(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req,
            [SignalRConnectionInfo(HubName = "healthcareSignalR")] SignalRConnectionInfo connectionInfo)
        {
            return connectionInfo;
        }

        [FunctionName("broadcast")]
        public static Task SendMessage(
            [EventGridTrigger] EventGridEvent eventGridEvent,
            [SignalR(HubName = "healthcareSignalR")] IAsyncCollector<SignalRMessage> signalRMessages,
            ILogger log)
        {
            SignalREventGridPayload payload = JsonConvert.DeserializeObject<SignalREventGridPayload>(eventGridEvent.Data.ToString());

            var message = new Dictionary<object, object>();

            payload.Data.Patch.ForEach(p =>
            {
                var chunks = p.Path.Split("/");
                message.Add($"{chunks[1]}_{chunks[2]}", p.Value);
                /*
                switch (p.Path)
                {
                    case "/temperature/value":
                    case "/temperature/alarm":
                    case "/battery/value":
                    case "/battery/alarm":
                    case "/saturation/value":
                    case "/saturation/alarm":
                    case "/heart_frequency/value":
                    case "/heart_frequency/alarm":
                    case "/breath_frequency/value":
                    case "/breath_frequency/alarm":
                    case "/blood_pressure/value":
                    case "/blood_pressure/alarm":
                    default:
                }
                */
            });


            log.LogInformation($"Message we are going to send: {message.ToString()}");

            return signalRMessages.AddAsync(
                new SignalRMessage
                {
                    Target = "newMessage",
                    Arguments = new[] { message }
                });
        }
    }
}