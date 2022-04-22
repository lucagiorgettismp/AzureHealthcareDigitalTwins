using Common.Utils.Exceptions;

namespace Simulator.Controller
{
    using AzureApi;
    using Common.Enums;
    using Common.Utils;
    using Microsoft.Azure.Devices.Client;
    using Model;
    using Model.Payload;
    using Newtonsoft.Json;
    using System;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Utils;
    using View;

    internal class SimulatorController
    {
        private readonly string _deviceId;
        private readonly SimulationForm _view;
        private CancellationTokenSource _tokenSource;
        private DeviceDataGenerator _deviceDataGenerator;
        private DeviceClient _deviceClient;

        public SimulatorController(string deviceId)
        {
            this._deviceId = deviceId;

            this._view = new SimulationForm
            {
                Text = "Simulation",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };
        }

        public async Task InitAsync()
        {
            try
            {
                var connectionString = await DeviceOperationsApi.GetConnectionString(_deviceId);
                this._deviceClient = DeviceClient.CreateFromConnectionString(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        internal void StopDevice()
        {
            this._view.Hide();

            this._tokenSource?.Cancel();
        }

        internal async Task StartDeviceAsync()
        {
            this._view.Show();

            this._tokenSource = new CancellationTokenSource();
            try
            {
                this._deviceDataGenerator = new DeviceDataGenerator(_deviceId);
            }
            catch (InvalidPropertyTypeException e)
            {
                Console.WriteLine(e);
            }

            await this.Simulation();
        }

        public async Task Simulation()
        {
            var msgCounter = 1;

            while (!_tokenSource.IsCancellationRequested)
            {
                var deviceData = _deviceDataGenerator.GetUpdatedDeviceData();

                this._view.UpdateValues(deviceData);

                var json = CreateJson(deviceData);
                var message = CreateMessage(json);

                PrintMessage(msgCounter, deviceData);
                await this._deviceClient.SendEventAsync(message);

                Console.WriteLine();

                await Task.Delay(1500);
                msgCounter += 1;
            }
        }

        private static void PrintMessage(int counter, DeviceData message)
        {
            Log.Ok($"[{counter}] Sending message at {DateTime.Now} and Message:" +
                $"\n{message.Temperature.SensorName}: {message.Temperature.Value}, {message.Temperature.UnitOfMeasurement}, {message.Temperature.InAlert}, " +
                $"Min: {message.Temperature.MinValue}, Max: {message.Temperature.MaxValue}," +
                $"\n{message.BloodPressure.SensorName}: {message.BloodPressure.Value} {message.BloodPressure.UnitOfMeasurement}, {message.BloodPressure.InAlert}," +
                $"Min: {message.BloodPressure.MinValue},Max: {message.BloodPressure.MaxValue}, Color: {message.BloodPressure.GraphColor}, " +
                $"\n{message.HeartFrequency.SensorName}: {message.HeartFrequency.Value} {message.HeartFrequency.UnitOfMeasurement}, {message.HeartFrequency.InAlert}," +
                $"Min: {message.HeartFrequency.MinValue},Max: {message.HeartFrequency.MaxValue},Color: {message.HeartFrequency.GraphColor}, " +
                $"\n{message.BreathFrequency.SensorName}: {message.BreathFrequency.Value} {message.BreathFrequency.UnitOfMeasurement}, {message.BreathFrequency.InAlert}," +
                $"Min: {message.BreathFrequency.MinValue},Max: {message.BreathFrequency.MaxValue},Color: {message.BreathFrequency.GraphColor}, " +
                $"\n{message.Saturation.SensorName}: {message.Saturation.Value} {message.Saturation.UnitOfMeasurement}, {message.Saturation.InAlert}, " +
                $"Min: {message.Saturation.MinValue},Max: {message.Saturation.MaxValue},Color: {message.Saturation.GraphColor}, " +
                $"\n{message.BatteryPower.SensorName}: {message.BatteryPower.Value} {message.BatteryPower.UnitOfMeasurement}, {message.BatteryPower.InAlert}," +
                $"Min: {message.BatteryPower.MinValue},Max: {message.BatteryPower.MaxValue}"
                );
        }

        private string CreateJson(DeviceData deviceData)
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

        private static Sensor<T> GetVitalSignsMonitorPayloadParameterFromParam<T>(DeviceDataProperty<T> dataProperty)
        {
            return new Sensor<T>
            {
                SensorName = dataProperty.SensorName,
                Alert = dataProperty.InAlert,
                GraphColor = dataProperty.GraphColor,
                SensorValue = new SensorValue<T>
                {
                    UnitOfMeasurement = dataProperty.UnitOfMeasurement,
                    Type = dataProperty.Type,
                    Value = dataProperty.Value,
                    MinValue = dataProperty.MinValue,
                    MaxValue = dataProperty.MaxValue
                }
            };
        }

        private static Microsoft.Azure.Devices.Client.Message CreateMessage(string jsonObject)
        {
            var message = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(jsonObject))
            {
                ContentType = "application/json",
                ContentEncoding = "UTF-8"
            };

            return message;
        }
    }
}