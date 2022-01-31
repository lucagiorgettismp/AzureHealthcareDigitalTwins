namespace Simulator.AzureApi
{
    using System;
    using System.IO;
    using Common.Utils;
    using Microsoft.Azure.Devices;
    using Microsoft.Azure.Devices.Client;
    using Microsoft.Extensions.Configuration;

    class AuthenticationApi
    {
        const string HOST = "host";
        const string DEVICE_ID = "deviceId";
        const string SHARED_ACCESS_KEY = "sharedAccesKey";
        const string IOTHUB = "connectionIoTHub";
        private static IConfiguration ReadConfig()
        {
            IConfiguration config = null;

            try
            {
                // Read configuration data from the 
                config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                    .Build();
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is UriFormatException)
            {
                Log.Error($"Could not read the client twin configuration.\n\nException message: {ex.Message}");
            }

            return config;
        }

        public static RegistryManager GetRegistryManager()
        {
            RegistryManager rm = null;
            IConfiguration config = ReadConfig();

            if (config != null)
            {
                rm = RegistryManager.CreateFromConnectionString(config[IOTHUB]);
                Log.Ok("Iot Hub authenticating successfully!");
                Console.WriteLine();
            }
            return rm;
        }

        public static string GetHost()
        {
            string host = null;
            IConfiguration config = ReadConfig();

            if(config != null)
            {
                host = config[HOST];
            }

            return host;
        }
    }
}
