﻿namespace Client.AzureApi
{
    using System;
    using System.IO;
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Common.Utils;
    using Microsoft.Azure.Devices;
    using Microsoft.Extensions.Configuration;

    class AuthenticationApi
    {

        const string HOST = "host";
        const string IOTHUB = "connectionIoTHub";
        private static IConfiguration ReadConfig()
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

        public static DigitalTwinsClient GetClient()
        {
            Uri adtInstanceUrl;

            DigitalTwinsClient twinClient = null;
            IConfiguration config = ReadConfig();

            if (config != null)
            {
                adtInstanceUrl = new Uri(config[HOST]);
                Log.Ok("Twin client authenticating...");
                var credential = new DefaultAzureCredential();
                twinClient = new DigitalTwinsClient(adtInstanceUrl, credential);

                Log.Ok($"Service twin client created – ready to go!");
                Console.WriteLine();
            }
            return twinClient;
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
    }
}
