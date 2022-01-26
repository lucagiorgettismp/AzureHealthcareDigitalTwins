namespace Controller
{
    using AzureApi;
    using Microsoft.Azure.Devices.Client;
    using Model;
    using Model.AzurePayloads;
    using Newtonsoft.Json;
    using System;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Utils;

    class Device
    {
        DeviceClient deviceClient;
        DeviceDataGenerator dataGenerator;

        public Device()
        {
            this.deviceClient = AuthenticationApi.GetDevice();
            this.dataGenerator = new DeviceDataGenerator();
        }

        public async Task SendMessageToIoTHub(CancellationToken token, CrudMode mode)
        {
            int msgCounter = 1;

            while (!token.IsCancellationRequested)
            {
                var deviceData = dataGenerator.GetUpdatedDeviceData();

                var json = CreateJSON(deviceData, mode);
                var message = CreateMessage(json);

                await deviceClient.SendEventAsync(message);
                Log.Ok($"[{msgCounter}] Sending message at {DateTime.Now} and Message : {json}");
                Console.WriteLine();

                await Task.Delay(1500);
                msgCounter += 1;
            }
        }

        private string CreateJSON(DeviceData deviceData, CrudMode mode)
        {
            var data = new VitalSignsMonitorPayload
            {
                Mode = mode,
                Data = mode != CrudMode.Delete ? new VitalSignsMonitorPayloadData
                {
                    Temperature = new VitalSignsMonitorPayloadParameter<double>(deviceData.Temperature, mode),
                    BloodPressure = new VitalSignsMonitorPayloadParameter<int>(deviceData.BloodPressure, mode),
                    Saturation = new VitalSignsMonitorPayloadParameter<int>(deviceData.Saturation, mode),
                    BreathFrequency = new VitalSignsMonitorPayloadParameter<int>(deviceData.BreathFrequency, mode),
                    HeartFrequency = new VitalSignsMonitorPayloadParameter<int>(deviceData.HeartFrequency, mode),
                    BatteryPower = new VitalSignsMonitorPayloadParameter<int>(deviceData.BatteryPower, mode)
                } : null
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
