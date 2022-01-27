namespace Simulator.AzureApi
{
    using System;
    using System.IO;
    using Common.Utils;
    using Microsoft.Azure.Devices.Client;
    using Microsoft.Extensions.Configuration;

    class AuthenticationApi
    {
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
                host = config["host"];
                deviceId = config["deviceId"];
                sharedAccessKey = config["sharedAccesKey"];

                Log.Ok("Device client authenticating...");

                string connectionString = $"HostName={host}DeviceId={deviceId}SharedAccessKey={sharedAccessKey}";
                deviceClient = DeviceClient.CreateFromConnectionString(connectionString);

                Log.Ok($"Service device client created – ready to go!");
                Console.WriteLine();
            }
            return deviceClient;
        }
    }
}
