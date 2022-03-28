namespace AppFunctions
{
    using Microsoft.Azure.WebJobs;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Azure.Messaging.EventHubs;

    public class ProcessDTUpdatetoTSI
    {
        [FunctionName("ProcessDTUpdatetoTSI")]
        public static async Task Run(
                    [EventHubTrigger("healthcaretwinseventhub", Connection = "EventHubAppSetting-Twins")] EventData myEventHubMessage,
                    [EventHub("healthcaretimeserieshub", Connection = "EventHubAppSetting-TSI")] IAsyncCollector<string> outputEvents,
                    ILogger log)
        {
            JObject message = (JObject)JsonConvert.DeserializeObject(Encoding.UTF8.GetString(myEventHubMessage.EventBody));
            log.LogInformation($"Reading event: {message}");

            // Read values that are replaced or added
            var tsiUpdate = new Dictionary<string, object>();
            foreach (var operation in message["patch"])
            {
                if (operation["op"].ToString() == "replace" || operation["op"].ToString() == "add")
                {
                    string path = operation["path"].ToString().Substring(1);
                    path = path.Replace("/", ".");
                    tsiUpdate.Add(path, operation["value"]);
                }
            }
            // Send an update if updates exist
            if (tsiUpdate.Count > 0)
            {
                tsiUpdate.Add("$dtId", myEventHubMessage.Properties["cloudEvents:subject"]);
                await outputEvents.AddAsync(JsonConvert.SerializeObject(tsiUpdate));
            }
        }
    }
}