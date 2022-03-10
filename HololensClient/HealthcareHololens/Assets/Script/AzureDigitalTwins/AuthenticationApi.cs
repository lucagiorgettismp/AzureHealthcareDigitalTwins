namespace AzureDigitalTwins
{
    using System;
    using Microsoft.Azure.Devices;
    using Microsoft.Extensions.Configuration;

    class AuthenticationApi
    {
        const string HOST = "host";
        const string IOTHUB = "connectionIoTHub";

        public static RegistryManager GetRegistryManager()
        {
            RegistryManager rm = null;
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("", optional: false, reloadOnChange: false)
                    .Build();

            if (config != null)
            {
                rm = RegistryManager.CreateFromConnectionString(config[IOTHUB]);
                Console.WriteLine();
            }
            return rm;
        }

        public static string GetHost()
        {
            string host = null;
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("", optional: false, reloadOnChange: false)
                    .Build();

            if (config != null)
            {
                host = config[HOST];
            }
            return host;
        }
    }
}
