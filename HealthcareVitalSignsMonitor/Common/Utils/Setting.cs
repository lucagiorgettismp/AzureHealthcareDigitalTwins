namespace Common.Utils
{
    using System;
    using System.IO;
    using Microsoft.Extensions.Configuration;
    public class Setting
    {

        const string SETTING_FILE = "appsettings.json";
        public static IConfiguration ReadConfig()
        {
            IConfiguration config = null;

            try
            {
                // Read configuration data from the 
                config = new ConfigurationBuilder()
                    .AddJsonFile(SETTING_FILE, optional: false, reloadOnChange: false)
                    .Build();
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is UriFormatException)
            {
                Log.Error($"Could not read the client twin configuration.\n\nException message: {ex.Message}");
            }
            return config;
        }
    }
}
