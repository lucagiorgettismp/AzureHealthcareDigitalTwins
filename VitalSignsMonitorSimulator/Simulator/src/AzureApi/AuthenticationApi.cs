namespace Simulator.AzureApi
{
    using System;
    using Common.Utils;
    using Microsoft.Azure.Devices;
    using Microsoft.Extensions.Configuration;

    class AuthenticationApi
    {
        const string HOST = "host";
        const string IOTHUB = "connectionIoTHub";

        public static RegistryManager GetRegistryManager()
        {
            RegistryManager rm = null;
            IConfiguration config = Setting.ReadConfig();

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
            IConfiguration config = Setting.ReadConfig();

            if(config != null)
            {
                host = config[HOST];
            }
            return host;
        }
    }
}
