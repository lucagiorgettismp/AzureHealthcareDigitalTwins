namespace Simulator.Controller
{
    using AzureApi;
    using Microsoft.Azure.Devices.Client;
    using Model;
    using AppFunctions.Model.AzurePayloads;
    using Newtonsoft.Json;
    using System;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Utils;
    using Common.Enums;
    using Common.Utils;

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
                    Temperature = GetVitalSignsMonitorPayloadParameterFromParam<double>(deviceData.Temperature, mode),
                    BloodPressure = GetVitalSignsMonitorPayloadParameterFromParam<int>(deviceData.BloodPressure, mode),
                    Saturation = GetVitalSignsMonitorPayloadParameterFromParam<int>(deviceData.Saturation, mode),
                    BreathFrequency = GetVitalSignsMonitorPayloadParameterFromParam<int>(deviceData.BreathFrequency, mode),
                    HeartFrequency = GetVitalSignsMonitorPayloadParameterFromParam<int>(deviceData.HeartFrequency, mode),
                    BatteryPower = GetVitalSignsMonitorPayloadParameterFromParam<int>(deviceData.BatteryPower, mode)
                } : null
            };

            return JsonConvert.SerializeObject(data);
        }

        private VitalSignsMonitorPayloadParameter<T> GetVitalSignsMonitorPayloadParameterFromParam<T>(DeviceDataProperty<T> property, CrudMode mode)
        {
            return new VitalSignsMonitorPayloadParameter<T>
            {
                Value = property.Value,
                InAlarm = property.InAlarm,
                UnitOfMeasurement = mode == CrudMode.Create ? property.UnitOfMeasurement : null
            };
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
