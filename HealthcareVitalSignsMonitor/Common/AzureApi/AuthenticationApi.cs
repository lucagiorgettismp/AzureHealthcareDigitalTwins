namespace Common.AzureApi
{
    using System;
    using Azure.DigitalTwins.Core;
    using Azure.Identity;
    using Utils;
    using Microsoft.Azure.Devices;
    using Microsoft.Extensions.Configuration;
    using Utils.Exceptions;

    public class AuthenticationApi
    {
        const string HOST_IOTHUB = "hostIotHub";
        const string HOST_CLIENT = "hostClient";
        const string IOTHUB = "connectionIoTHub";

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ClientAuthenticationException"></exception>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="AppSettingsReadingException"></exception>
        /// <returns></returns>
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
