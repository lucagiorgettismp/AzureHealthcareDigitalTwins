namespace AppFunctions
{
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
    using System.Threading.Tasks;

    public class SignalRFunction
    {
        public static double temperature;

        [FunctionName("NegotiateSignalR")]
        public static SignalRConnectionInfo GetSignalRInfo(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req,
            [SignalRConnectionInfo(HubName = "healthcareSignalR")] SignalRConnectionInfo connectionInfo)
        {
            return connectionInfo;
        }

        [FunctionName("SendBroadcastSignalRMessage")]
        public static Task SendMessage(
            [EventGridTrigger] EventGridEvent eventGridEvent,
            [SignalR(HubName = "healthcareSignalR")] IAsyncCollector<SignalRMessage> signalRMessages,
            ILogger log)
        {
            JObject eventGridData = (JObject)JsonConvert.DeserializeObject(eventGridEvent.Data.ToString());

            log.LogInformation($"Event grid message: {eventGridData}");

            var patch = (JObject)eventGridData["data"]["patch"][0];
            if (patch["path"].ToString().Contains("/temperature"))
            {
                temperature = Math.Round(patch["value"].ToObject<double>(), 2);
            }

            var message = new Dictionary<object, object>
            {
                { "temperatureInFahrenheit", temperature},
            };

            log.LogInformation($"Message we are going to send: {message}");

            return signalRMessages.AddAsync(
                new SignalRMessage
                {
                    Target = "newMessage",
                    Arguments = new[] { message }
                });
        }
    }
}