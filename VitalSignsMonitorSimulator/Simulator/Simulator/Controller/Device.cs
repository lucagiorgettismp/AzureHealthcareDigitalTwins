using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using Simulator.Simulator.Model;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulator.Simulator
{
    class Device
    {

        DeviceClient deviceClient;
        DeviceDataGenerator dataGenerator;
        static int msgCounter = 1;

        public Device()
        {
            this.deviceClient = AuthenticationApi.Device();
            this.dataGenerator = new DeviceDataGenerator();
        }

        public async Task SendMessageToIoTHub(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var deviceData = dataGenerator.GetUpdatedDeviceData();

                var json = CreateJSON(deviceData);
                var message = CreateMessage(json);

                await deviceClient.SendEventAsync(message);
                Console.WriteLine($"[{msgCounter}] Sending message at {DateTime.Now} and Message : {json}");

                await Task.Delay(1500);
                msgCounter += 1;
            }
        }

        private string CreateJSON(DeviceData deviceData)
        {
            var data = new
            {
                temperature = Math.Round(value: (double) deviceData.Temperature.Value, 1),
                bloodPressure = deviceData.BloodPressure,
                saturation = deviceData.Saturation,
                breathFrequency = deviceData.BreathFrequency,
                heartFrequency = deviceData.HeartFrequency,
                batteryPower = deviceData.BatteryPower
            };

            return JsonConvert.SerializeObject(data);
        }

        private static Message CreateMessage(string jsonObject)
        {
            var message = new Message(Encoding.ASCII.GetBytes(jsonObject));

            message.ContentType = "application/json";
            message.ContentEncoding = "UTF-8";

            return message;
        }
    }
}
