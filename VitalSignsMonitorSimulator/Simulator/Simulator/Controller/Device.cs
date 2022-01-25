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

        public async Task SendMessageToIoTHub(CancellationToken token, CrudMode mode)
        {
            while (!token.IsCancellationRequested)
            {
                var deviceData = dataGenerator.GetUpdatedDeviceData();

                var json = CreateJSON(deviceData, mode);
                var message = CreateMessage(json);

                await deviceClient.SendEventAsync(message);
                Console.WriteLine($"[{msgCounter}] Sending message at {DateTime.Now} and Message : {json}");

                await Task.Delay(1500);
                msgCounter += 1;
            }
        }

        private string CreateJSON(DeviceData deviceData, CrudMode mode)
        {
            var data = new VitalSignsMonitorPayload
            {
                Mode = mode,
                Data = new VitalSignsMonitorPayloadData
                {
                    Temperature = new VitalSignsMonitorPayloadParameter(deviceData.Temperature, mode)
                    {
                        Value = Math.Round(value: Convert.ToDouble(deviceData.Temperature.Value), 1),
                    },
                    BloodPressure = new VitalSignsMonitorPayloadParameter(deviceData.BloodPressure, mode)
                    {
                        Value = Convert.ToInt64(deviceData.BloodPressure.Value),
                    },
                    Saturation = new VitalSignsMonitorPayloadParameter(deviceData.Saturation, mode)
                    {
                        Value = Convert.ToInt64(deviceData.Saturation.Value),
                    },
                    BreathFrequency = new VitalSignsMonitorPayloadParameter(deviceData.BreathFrequency, mode)
                    {
                        Value = Convert.ToInt64(deviceData.BreathFrequency.Value),
                    },
                    HeartFrequency = new VitalSignsMonitorPayloadParameter(deviceData.HeartFrequency, mode)
                    {
                        Value = Convert.ToInt64(deviceData.HeartFrequency.Value),
                    },
                    BatteryPower = new VitalSignsMonitorPayloadParameter(deviceData.BatteryPower, mode)
                    {
                        Value = Convert.ToInt64(deviceData.BatteryPower.Value)
                    }              
                }
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
