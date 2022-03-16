namespace Common.AzureApi
{
    using System;
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Common.Utils;
    using Microsoft.Azure.Devices;
    using Microsoft.Extensions.Configuration;

    public class AuthenticationApi
    {
        const string HOST_IOTHUB = "hostIotHub";
        const string HOST_CLIENT = "hostClient";
        const string IOTHUB = "connectionIoTHub";

        public static DigitalTwinsClient GetClient()
        {
            Uri adtInstanceUrl;

            DigitalTwinsClient twinClient = null;
            IConfiguration config = Setting.ReadConfig();

            if (config != null)
            {
                adtInstanceUrl = new Uri(config[HOST_CLIENT]);
                Log.Ok("Twin client authenticating...");
                var credential = new DefaultAzureCredential();
                twinClient = new DigitalTwinsClient(adtInstanceUrl, credential);

                Log.Ok($"Service twin client created – ready to go!");
                Console.WriteLine();
            }
            return twinClient;
        }

        public static string GetHost()
        {
            string host = null;
            IConfiguration config = Setting.ReadConfig();

            if (config != null)
            {
                host = config[HOST_IOTHUB];
            }
            return host;
        }

        public static RegistryManager GetRegistryManager()
        {
            RegistryManager rm = null;
            IConfiguration config = Setting.ReadConfig();

            if (config != null)
            {
                rm = RegistryManager.CreateFromConnectionString(config[IOTHUB]);
                Log.Ok("Iot Hub authenticating successfully!");
                Console.WriteLine();
            }
            return rm;
        }
    }
}
