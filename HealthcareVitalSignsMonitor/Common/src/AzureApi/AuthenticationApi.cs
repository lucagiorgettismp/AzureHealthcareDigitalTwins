namespace Common.AzureApi
{
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Microsoft.Azure.Devices;
    using System;
    using Utils;
    using Utils.Exceptions;

    public class AuthenticationApi
    {
        const string HOST_IOTHUB = "hostIotHub";
        const string HOST_CLIENT = "hostClient";
        const string IOTHUB = "connectionIoTHub";

        /// <exception cref="ClientAuthenticationException"/>
        public static DigitalTwinsClient GetClient()
        {
            try
            {
                DigitalTwinsClient twinClient = null;
                var config = AppSettings.ReadConfig();

                if (config != null)
                {
                    var adtInstanceUrl = new Uri(config[HOST_CLIENT]);
                    Log.Ok("Twin client authenticating...");
                    var credential = new DefaultAzureCredential();
                    twinClient = new DigitalTwinsClient(adtInstanceUrl, credential);

                    Log.Ok("Service twin client created – ready to go!");
                    Console.WriteLine();
                }

                return twinClient;
            }
            catch (AppSettingsReadingException e)
            {
                throw new ClientAuthenticationException(e);
            }
        }
        
        /// <exception cref="AppSettingsReadingException"/>
        public static string GetHost()
        {
            string host = null;
            var config = AppSettings.ReadConfig();

            if (config != null)
            {
                host = config[HOST_IOTHUB];
            }

            return host;
        }

        public static RegistryManager GetRegistryManager()
        {
            RegistryManager rm = null;
            var config = AppSettings.ReadConfig();

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
