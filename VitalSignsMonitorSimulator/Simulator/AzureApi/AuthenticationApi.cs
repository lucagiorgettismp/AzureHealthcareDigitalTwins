using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static DigitalTwinsClient AuthenticationTwinClient()
        {
            Uri adtInstanceUrl;
            try
            {
                // Read configuration data from the 
                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                    .Build();
                adtInstanceUrl = new Uri(config["instanceUrl"]);
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is UriFormatException)
            {
                Log.Error($"Could not read the client twin configuration.\n\nException message: {ex.Message}");
                return twinClient;
            }

            Log.Ok("Twin client authenticating...");
            var credential = new DefaultAzureCredential();
            twinClient = new DigitalTwinsClient(adtInstanceUrl, credential);

            Log.Ok($"Service twin client created – ready to go!");

            return twinClient;
        }

        public static DeviceClient AuthenticationDeviceClient()
        {
            String host;
            String deviceId;
            String sharedAccessKey;
            try
            {
                // Read configuration data from the 
                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                    .Build();

                host = config["host"];
                deviceId = config["deviceId"];
                sharedAccessKey = config["sharedAccesKey"];
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is UriFormatException)
            {
                Log.Error($"Could not read the client device configuration.\n\nException message: {ex.Message}");
                return deviceClient;
            }

            Log.Ok("Device client authenticating...");

            String connectionString = $"HostName={host}DeviceId={deviceId}SharedAccessKey={sharedAccessKey}";
            deviceClient = DeviceClient.CreateFromConnectionString(connectionString);

            Log.Ok($"Service device client created – ready to go!");

            return deviceClient;
        }
    }
}
