namespace AzureDigitalTwins
{
    using Microsoft.Extensions.Configuration;

    class AuthenticationApi
    {
        const string HOST_IOTHUB = "hostIotHub";
        public static IConfiguration GetRegistryManager()
        {
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("", optional: false, reloadOnChange: false)
                    .Build();

            return config;
        }

        public static string GetHostDevice()
        {
            string host = null;
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("", optional: false, reloadOnChange: false)
                    .Build();

            if (config != null)
            {
                host = config[HOST_IOTHUB];
            }
            return host;
        }
    }
}
