namespace AzureDigitalTwins
{
    using Newtonsoft.Json;

    class AuthenticationApi
    {
        public static ConnectionConfig GetRegistryManager(string connectionString)
        {
            return JsonConvert.DeserializeObject<ConnectionConfig>(connectionString);
        }

        public class ConnectionConfig
        {
            [JsonProperty("hostIotHub")]
            public string HostIotHub { get; set; }

            [JsonProperty("hostClient")]
            public string HostClient { get; set; }

            [JsonProperty("connectionIoTHub")]
            public string ConnectionIoTHub { get; set; }
        }
    }
}
