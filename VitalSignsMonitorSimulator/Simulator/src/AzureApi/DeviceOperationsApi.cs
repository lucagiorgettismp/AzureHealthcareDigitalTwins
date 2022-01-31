using Common.Utils;
using Microsoft.Azure.Devices;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simulator.AzureApi
{
    class DeviceOperationsApi
    {
        const string QUERY_GET_ALL_DEVICES = "SELECT * FROM devices";
        public static async Task<List<JObject>> getDevices()
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
    }
}
