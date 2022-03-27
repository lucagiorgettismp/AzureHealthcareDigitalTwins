namespace AzureDigitalTwins
{
    using UnityEngine;
    using Newtonsoft.Json;

    class AuthenticationApi
    {
        const string FILE_NAME = "appsettings";

        public static ConnectionConfig GetRegistryManager()
        {
            TextAsset jsonFile = Resources.Load<TextAsset>(FILE_NAME);

            ConnectionConfig setting = JsonConvert.DeserializeObject<ConnectionConfig>(jsonFile.text);

            return setting;
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
