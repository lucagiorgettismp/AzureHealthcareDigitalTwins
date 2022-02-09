namespace Simulator.Controller
{
    using Common.Enums;
    using Common.Utils;
    using Microsoft.Azure.Devices.Client;
    using Model;
    using Newtonsoft.Json;
    using Simulator.Model.Payload;
    using Simulator.src;
    using System;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Utils;

    class Device
    {
        readonly DeviceClient deviceClient;
        readonly DeviceDataGenerator dataGenerator;

        public Device(string connection)
        {
            this.deviceClient = DeviceClient.CreateFromConnectionString(connection);
            this.dataGenerator = new DeviceDataGenerator();
        }

        public async Task SendMessageToIoTHub(SimulationForm form, CancellationToken token, CrudMode mode)
        {
            int msgCounter = 1;

            while (!token.IsCancellationRequested)
            {
                var deviceData = dataGenerator.GetUpdatedDeviceData();
                form.updateValues(deviceData);

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
            var data = new EventGridMessagePayloadBody
            {
                Mode = mode,
                Data = mode != CrudMode.Delete ? new EventGridMessagePayloadData
                {
                    Temperature = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.Temperature, mode),
                    BloodPressure = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BloodPressure, mode),
                    Saturation = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.Saturation, mode),
                    BreathFrequency = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BreathFrequency, mode),
                    HeartFrequency = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.HeartFrequency, mode),
                    BatteryPower = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BatteryPower, mode)
                } : null
            };

            return JsonConvert.SerializeObject(data);
        }

        private Sensor<T> GetVitalSignsMonitorPayloadParameterFromParam<T>(DeviceDataProperty<T> dataProperty, CrudMode mode)
        {
            return new Sensor<T>
            {
                SensorName = dataProperty.SensorName,
                Alarm = dataProperty.InAlarm,
                SensorValue = new SensorValue<T>
                {
                    UnitOfMeasurement = dataProperty.UnitOfMeasurement,
                    Symbol = dataProperty.Symbol,
                    Type = dataProperty.Type,
                    Value = dataProperty.Value
                }
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
