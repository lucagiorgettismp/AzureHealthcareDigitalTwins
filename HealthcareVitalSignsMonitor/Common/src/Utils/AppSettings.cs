using Common.Utils.Exceptions;

namespace Common.Utils
{
    using System;
    using System.IO;
    using Microsoft.Extensions.Configuration;
    public class AppSettings
    {
        const string SETTING_FILE = "appsettings.json";

        /// <exception cref="AppSettingsReadingException"/>
        public static IConfiguration ReadConfig()
        {
            try
            {
                // Read configuration data from the 
                var config = new ConfigurationBuilder()
                    .AddJsonFile(SETTING_FILE, optional: false, reloadOnChange: false)
                    .Build();

                return config;
            } catch (Exception ex) when (ex is FileNotFoundException || ex is UriFormatException)
            {
                throw new AppSettingsReadingException("Cannot find client twin configuration file.", ex);
            } catch (Exception ex)
            {
                throw new AppSettingsReadingException("Error while reading client twin configuration", ex);
            }
        }
    }
}
