﻿using Azure;
using Microsoft.Azure.Devices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureDigitalTwins
{
    class DeviceOperationsApi
    {
        const string QUERY_GET_ALL_DEVICES = "SELECT * FROM devices";
        public static async Task<List<JObject>> GetDevices()
        {
            RegistryManager rm = AuthenticationApi.GetRegistryManager();

            var query = rm.CreateQuery(QUERY_GET_ALL_DEVICES);
            List<JObject> jsonDevices = new List<JObject>();

            while (query.HasMoreResults)
            {
                var devices = await query.GetNextAsJsonAsync();
                foreach (var device in devices)
                {
                    JObject json = JObject.Parse(device);
                    jsonDevices.Add(json);
                }
            }
            return jsonDevices;
        }

        public static async Task<string> GetConnectionString(string deviceId)
        {
            string connection = null;
            RegistryManager rm = AuthenticationApi.GetRegistryManager();
            try
            {
                // Get device
                Device device = await rm.GetDeviceAsync(deviceId);
                string host = AuthenticationApi.GetHost();

                // Get string connection
                connection = $"HostName={host};DeviceId={device.Id};SharedAccessKey={device.Authentication.SymmetricKey.PrimaryKey}";
            }
            catch (RequestFailedException)
            {
            }
            Console.WriteLine();

            return connection;
        }
    }
}
