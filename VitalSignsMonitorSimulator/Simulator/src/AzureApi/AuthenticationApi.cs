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
        private static IConfiguration readConfig()
        {
            IConfiguration config;

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
                return null;
            }

            return config;
        }

        public static DeviceClient GetDevice()
        {
            string host;
            string deviceId;
            string sharedAccessKey;

            DeviceClient deviceClient = null;
            IConfiguration config = readConfig();

            if(config != null)
            {
                host = config[HOST];
                deviceId = config[DEVICE_ID];
                sharedAccessKey = config[SHARED_ACCESS_KEY];

                Log.Ok("Device client authenticating...");

                string connectionString = $"HostName={host}DeviceId={deviceId}SharedAccessKey={sharedAccessKey}";
                deviceClient = DeviceClient.CreateFromConnectionString(connectionString);

                Log.Ok($"Service device client created – ready to go!");
                Console.WriteLine();
            }
            return deviceClient;
        }

        public static RegistryManager GetRegistryManager()
        {
            RegistryManager rm = null;
            IConfiguration config = readConfig();

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
