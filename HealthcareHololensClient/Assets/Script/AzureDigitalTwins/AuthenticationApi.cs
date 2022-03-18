namespace AzureDigitalTwins
{
    using UnityEngine;
    using System;

    class AuthenticationApi
    {
        const string FILE_NAME = "appsettings";

        public static ConnectionConfig GetRegistryManager()
        {
            TextAsset jsonFile = Resources.Load<TextAsset>(FILE_NAME);
            ConnectionConfig setting = JsonUtility.FromJson<ConnectionConfig>(jsonFile.text);

            return setting;
        }

        [Serializable]
        public class ConnectionConfig
        {
            public string hostIotHub;
            public string hostClient;
            public string connectionIoTHub;
        }
    }
}
