using Common.Utils.Exceptions;

namespace Simulator.AzureApi
{
    using Azure;
    using Common.AzureApi;
    using Common.Utils;
    using Common.Utils.Exceptions;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    internal class DeviceOperationsApi
    {
        const string QUERY_GET_ALL_DEVICES = "SELECT * FROM devices";

        public static async Task<List<JObject>> GetDevices()
        {
            var registryManager = AuthenticationApi.GetRegistryManager();
            var query = registryManager.CreateQuery(QUERY_GET_ALL_DEVICES);
            var jsonDevices = new List<JObject>();

            while (query.HasMoreResults)
            {
                var devices = await query.GetNextAsJsonAsync();
                jsonDevices.AddRange(devices.Select(device => JObject.Parse(device)));
            }
            return jsonDevices;
        }

        /// <exception cref="ConnectionStringException"/>
        public static async Task<string> GetConnectionString(string deviceId)
        {
            string connection = null;
            var registryManager = AuthenticationApi.GetRegistryManager();
            try
            {
                // Get device
                var device = await registryManager.GetDeviceAsync(deviceId);
                var host = AuthenticationApi.GetHost();

                // Get string connection
                connection = $"HostName={host};DeviceId={device.Id};SharedAccessKey={device.Authentication.SymmetricKey.PrimaryKey}";
                Log.Ok($"Connections string of device {device.Id}: {connection}");
            }
            catch (Exception e) when (e is RequestFailedException || e is AppSettingsReadingException)
            {
                Log.Error($"Create device error: {e}: {e.Message}");

                throw new ConnectionStringException("Cannot get the device connection string", e);
            }

            return connection;
        }
    }
}
