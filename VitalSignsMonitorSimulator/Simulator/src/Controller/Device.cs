namespace Simulator.Controller
{
    using Azure.DigitalTwins.Core;
    using Common.AzureApi;
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
        readonly DigitalTwinsClient twinClient;
        readonly PatientModel patient = null;
        readonly string name;

        public Device(string name, DeviceClient client)
        {
            this.deviceClient = client;
            this.dataGenerator = new DeviceDataGenerator();
            this.twinClient = AuthenticationApi.GetClient();
            this.name = name;
        }

        public async Task SendMessageToIoTHub(SimulationForm form, CancellationToken token)
        {
            int msgCounter = 1;

            while (!token.IsCancellationRequested)
            {
                DeviceData deviceData = dataGenerator.GetUpdatedDeviceData();
                form.UpdateValues(deviceData);

                string json = CreateJSON(deviceData);
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
                $"\n{message.Temperature.SensorName}: {message.Temperature.Value}, {message.Temperature.Symbol}, {message.Temperature.InAlarm}, " +
                $"Min: {message.Temperature.MinValue}, Max: {message.Temperature.MaxValue}," +
                $"\n{message.BloodPressure.SensorName}: {message.BloodPressure.Value} {message.BloodPressure.Symbol}, {message.BloodPressure.InAlarm}," +
                $"Min: {message.BloodPressure.MinValue},Max: {message.BloodPressure.MaxValue}, Color: {message.BloodPressure.GraphColor}, " +
                $"\n{message.HeartFrequency.SensorName}: {message.HeartFrequency.Value} {message.HeartFrequency.Symbol}, {message.HeartFrequency.InAlarm}," +
                $"Min: {message.HeartFrequency.MinValue},Max: {message.HeartFrequency.MaxValue},Color: {message.HeartFrequency.GraphColor}, " +
                $"\n{message.BreathFrequency.SensorName}: {message.BreathFrequency.Value} {message.BreathFrequency.Symbol}, {message.BreathFrequency.InAlarm}," +
                $"Min: {message.BreathFrequency.MinValue},Max: {message.BreathFrequency.MaxValue},Color: {message.BreathFrequency.GraphColor}, " +
                $"\n{message.Saturation.SensorName}: {message.Saturation.Value} {message.Saturation.Symbol}, {message.Saturation.InAlarm}, " +
                $"Min: {message.Saturation.MinValue},Max: {message.Saturation.MaxValue},Color: {message.Saturation.GraphColor}, " +
                $"\n{message.BatteryPower.SensorName}: {message.BatteryPower.Value} {message.BatteryPower.Symbol}, {message.BatteryPower.InAlarm}," +
                $"Min: {message.BatteryPower.MinValue},Max: {message.BatteryPower.MaxValue}" 
                );
        }

        private string CreateJSON(DeviceData deviceData)
        {
            var data = new EventGridMessagePayloadBody
            {
                Mode = UpdateMode.Telemetry,
                Data = new EventGridMessagePayloadData
                {
                    Temperature = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.Temperature),
                    BloodPressure = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BloodPressure),
                    Saturation = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.Saturation),
                    BreathFrequency = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BreathFrequency),
                    HeartFrequency = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.HeartFrequency),
                    BatteryPower = GetVitalSignsMonitorPayloadParameterFromParam(deviceData.BatteryPower)
                }
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
            var message = new Message(Encoding.UTF8.GetBytes(jsonObject))
            {
                ContentType = "application/json",
                ContentEncoding = "UTF-8"
            };

            return message;
        }
    }
}
