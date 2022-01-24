using System;
using System.IO;
using Azure.DigitalTwins.Core;
using Azure.Identity;
using Microsoft.Azure.Devices.Client;
using Microsoft.Extensions.Configuration;

namespace Simulator
{
    class AuthenticationApi
    {
        private static DigitalTwinsClient twinClient = null;
        private static DeviceClient deviceClient = null;

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

        public static DigitalTwinsClient Twins()
        {
            Uri adtInstanceUrl;

            IConfiguration config = readConfig();

            if (config != null)
            {
                adtInstanceUrl = new Uri(config["instanceUrl"]);
                Log.Ok("Twin client authenticating...");
                var credential = new DefaultAzureCredential();
                twinClient = new DigitalTwinsClient(adtInstanceUrl, credential);

                Log.Ok($"Service twin client created – ready to go!");
            }
            return twinClient;
        }

        public static DeviceClient Device()
        {
            String host;
            String deviceId;
            String sharedAccessKey;

            IConfiguration config = readConfig();

            if(config != null)
            {
                host = config["host"];
                deviceId = config["deviceId"];
                sharedAccessKey = config["sharedAccesKey"];

                Log.Ok("Device client authenticating...");

                String connectionString = $"HostName={host}DeviceId={deviceId}SharedAccessKey={sharedAccessKey}";
                deviceClient = DeviceClient.CreateFromConnectionString(connectionString);

                Log.Ok($"Service device client created – ready to go!");
            }
            return deviceClient;
        }
    }
}
