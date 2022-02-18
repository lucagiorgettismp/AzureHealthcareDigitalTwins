namespace Simulator.Controller
{
    using Common.Enums;
    using Common.Utils;
    using Microsoft.Azure.Devices.Client;
    using Model;
    using Newtonsoft.Json;
    using Simulator.Model.Payload;
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
                DeviceData deviceData = dataGenerator.GetUpdatedDeviceData();
                form.UpdateValues(deviceData);

                string json = CreateJSON(deviceData, mode);
                Message message = CreateMessage(json);

                ShowMessage(msgCounter, deviceData);
                await deviceClient.SendEventAsync(message);
                
                Console.WriteLine();

                await Task.Delay(1500);
                msgCounter += 1;
            }
        }

        private void ShowMessage(int counter, DeviceData message)
        {
            Log.Ok($"[{counter}] Sending message at {DateTime.Now} and Message:" +
                $"\n{message.Temperature.SensorName}: {message.Temperature.Value} {message.Temperature.Symbol}, {message.Temperature.InAlarm}," +
                $"\n{message.BloodPressure.SensorName}: {message.BloodPressure.Value} {message.BloodPressure.Symbol}, {message.BloodPressure.InAlarm}," +
                $"\n{message.HeartFrequency.SensorName}: {message.HeartFrequency.Value} {message.HeartFrequency.Symbol}, {message.HeartFrequency.InAlarm}," +
                $"\n{message.BreathFrequency.SensorName}: {message.BreathFrequency.Value} {message.BreathFrequency.Symbol}, {message.BreathFrequency.InAlarm}," +
                $"\n{message.Saturation.SensorName}: {message.Saturation.Value} {message.Saturation.Symbol}, {message.Saturation.InAlarm}," +
                $"\n{message.BatteryPower.SensorName}: {message.BatteryPower.Value} {message.BatteryPower.Symbol}, {message.BatteryPower.InAlarm}," 
                );
        }

        private string CreateJSON(DeviceData deviceData, CrudMode mode)
        {
            var data = new EventGridMessagePayloadBody
            {
                Mode = mode,
                Data = mode != CrudMode.Delete ? new EventGridMessagePayloadData
                {
                    Temperature = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.Temperature),
                    BloodPressure = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BloodPressure),
                    Saturation = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.Saturation),
                    BreathFrequency = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BreathFrequency),
                    HeartFrequency = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.HeartFrequency),
                    BatteryPower = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BatteryPower)
                } : null
            };

            return JsonConvert.SerializeObject(data);
        }

        private Sensor<T> GetVitalSignsMonitorPayloadParameterFromParam<T>(DeviceDataProperty<T> dataProperty)
        {
            return new Sensor<T>
            {
                SensorName = dataProperty.SensorName,
                Alarm = dataProperty.InAlarm,
                GraphColor = dataProperty.GraphColor,
                SensorValue = new SensorValue<T>
                {
                    UnitOfMeasurement = dataProperty.UnitOfMeasurement,
                    Symbol = dataProperty.Symbol,
                    Type = dataProperty.Type,
                    Value = dataProperty.Value,
                    MinValue = dataProperty.MinValue,
                    MaxValue = dataProperty.MaxValue
                }
            };
        }

        private static Message CreateMessage(string jsonObject)
        {
            var message = new Message(Encoding.ASCII.GetBytes(jsonObject))
            {
                ContentType = "application/json",
                ContentEncoding = "UTF-8"
            };

            return message;
        }
    }
}
