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
    using System.Text;
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
                var builder = new StringBuilder();

                var chunks = p.Path.Split("/").ToList();

                chunks.RemoveAt(0);
                builder.Append(chunks[0]);
                chunks.RemoveAt(0);

                foreach (string chunk in chunks)
                {
                    builder.Append($"_{chunk}");
                }

                message.Add(builder.ToString(), p.Value);              
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