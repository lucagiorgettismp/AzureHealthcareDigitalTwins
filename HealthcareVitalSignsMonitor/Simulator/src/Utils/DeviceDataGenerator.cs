namespace Simulator.Utils
{
    using Model;
    using Simulator.src;
    using System;
    using System.Configuration;
    using System.Globalization;

    public class DeviceDataGenerator
    {
        private DeviceData deviceData;
        private readonly Random random;

        const string IntType = "int";
        const string DoubleType = "double";

        const string RED = "255,0,0";
        const string GREEN = "0,255,0";
        const string YELLOW = "255,255,0";

        public DeviceDataGenerator(string deviceId)
        {
            random = new Random();
            InitDeviceData(deviceId);
        }

        private void InitDeviceData(string deviceId)
        {
            var appSettings = ConfigurationManager.AppSettings;

            double.TryParse(appSettings["TemperatureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureUpdateDelta);
            double.TryParse(appSettings["TemperatureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureInitValue);

            var userSettings = SettingsManager.ReadUserSettings(deviceId);

            var temperature = new DeviceDataPropertyMinMaxThreshold<double>
            {
                UnitOfMeasurement = userSettings.Temperature.UnitOfMeasurement,
                MinValue = userSettings.Temperature.MinValue,
                MaxValue = userSettings.Temperature.MaxValue,
                MinAlertThreashold = userSettings.Temperature.MinAlertThreashold,
                MaxAlertThrehshold = userSettings.Temperature.MaxAlertThreashold,
                UpdateDelta = temperatureUpdateDelta,
                SensorName = appSettings["TemperatureSensorName"],
                Type = DoubleType,
            };

            temperature.SetValue(temperatureInitValue);

            var batteryPower = new DeviceDataPropertyMinThreshold<int>
            {
                UnitOfMeasurement = userSettings.BatteryPower.UnitOfMeasurement,
                MinValue = userSettings.BatteryPower.MinValue,
                MaxValue = userSettings.BatteryPower.MaxValue,
                MinAlertThreashold = userSettings.BatteryPower.MinAlertThreashold,
                UpdateDelta = Convert.ToInt32(appSettings["BatteryUpdateDelta"]),
                SensorName = appSettings["BatterySensorName"],
                Type = IntType,
            };
            batteryPower.SetValue(Convert.ToInt32(appSettings["BatteryInitValue"]));

            var bloodPressure = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = userSettings.BloodPressure.UnitOfMeasurement,
                MinValue = userSettings.BloodPressure.MinValue,
                MaxValue = userSettings.BloodPressure.MaxValue,
                MinAlertThreashold = userSettings.BloodPressure.MinAlertThreashold,
                MaxAlertThrehshold = userSettings.BloodPressure.MaxAlertThreashold,
                UpdateDelta = Convert.ToInt32(appSettings["BloodPressureUpdateDelta"]),
                SensorName = appSettings["BloodPressureSensorName"],
                Type = IntType,
                GraphColor = YELLOW
            };
            bloodPressure.SetValue(Convert.ToInt32(appSettings["BloodPressureInitValue"]));

            var breathFrequency = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = userSettings.BreathFrequency.UnitOfMeasurement,
                MinValue = userSettings.BreathFrequency.MinValue,
                MaxValue = userSettings.BreathFrequency.MaxValue,
                MinAlertThreashold = userSettings.BreathFrequency.MinAlertThreashold,
                MaxAlertThrehshold = userSettings.BreathFrequency.MaxAlertThreashold,
                UpdateDelta = Convert.ToInt32(appSettings["BreathFrequencyUpdateDelta"]),
                SensorName = appSettings["BreathFrequencySensorName"],
                Type = IntType,
                GraphColor = GREEN
            };
            breathFrequency.SetValue(Convert.ToInt32(appSettings["BreathFrequencyInitValue"]));

            var heartFrequency = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = userSettings.HeartFrequency.UnitOfMeasurement,
                MinValue = userSettings.HeartFrequency.MinValue,
                MaxValue = userSettings.HeartFrequency.MaxValue,
                MinAlertThreashold = userSettings.HeartFrequency.MinAlertThreashold,
                MaxAlertThrehshold = userSettings.HeartFrequency.MaxAlertThreashold,
                UpdateDelta = Convert.ToInt32(appSettings["HeartFrequencyUpdateDelta"]),
                SensorName = appSettings["HeartFrequencySensorName"],
                Type = IntType,
                GraphColor = GREEN
            };
            heartFrequency.SetValue(Convert.ToInt32(appSettings["HeartFrequencyInitValue"]));

            var saturation = new DeviceDataPropertyMinThreshold<int>
            {
                UnitOfMeasurement = userSettings.Saturation.UnitOfMeasurement,
                MinValue = userSettings.Saturation.MinValue,
                MaxValue = userSettings.Saturation.MaxValue,
                MinAlertThreashold = userSettings.Saturation.MinAlertThreashold,
                UpdateDelta = Convert.ToInt32(appSettings["SaturationUpdateDelta"]),
                SensorName = appSettings["SaturationSensorName"],
                Type = IntType,
                InAlarm = false,
                GraphColor = RED
            };
            saturation.SetValue(Convert.ToInt32(appSettings["SaturationInitValue"]));

            deviceData = new DeviceData
            {
                Temperature = temperature,
                BatteryPower = batteryPower,
                BloodPressure = bloodPressure,
                BreathFrequency = breathFrequency,
                HeartFrequency = heartFrequency,
                Saturation = saturation
            };
        }

        public DeviceData GetUpdatedDeviceData()
        {
            var newData = this.deviceData;

            newData.Temperature.SetValue(this.GenerateDoubleValue(
                (double)(object)deviceData.Temperature.Value,
                (double)(object)deviceData.Temperature.UpdateDelta,
                (double)(object)deviceData.Temperature.MinValue,
                (double)(object)deviceData.Temperature.MaxValue));

            newData.BloodPressure.SetValue(this.GenerateIntValue(
                deviceData.BloodPressure.Value,
                deviceData.BloodPressure.UpdateDelta,
                deviceData.BloodPressure.MinValue,
                deviceData.BloodPressure.MaxValue, 
                false));

            newData.BatteryPower.SetValue(this.GenerateIntValue(
                deviceData.BatteryPower.Value,
                deviceData.BatteryPower.UpdateDelta,
                deviceData.BatteryPower.MinValue,
                deviceData.BatteryPower.MaxValue,
                true));

            newData.Saturation.SetValue(this.GenerateIntValue(
                deviceData.Saturation.Value,
                deviceData.Saturation.UpdateDelta,
                deviceData.Saturation.MinValue,
                deviceData.Saturation.MaxValue,
                false));

            newData.BreathFrequency.SetValue(this.GenerateIntValue(
                deviceData.BreathFrequency.Value,
                deviceData.BreathFrequency.UpdateDelta,
                deviceData.BreathFrequency.MinValue,
                deviceData.BreathFrequency.MaxValue,
                false));

            newData.HeartFrequency.SetValue(this.GenerateIntValue(
                deviceData.HeartFrequency.Value,
                deviceData.HeartFrequency.UpdateDelta,
                deviceData.HeartFrequency.MinValue,
                deviceData.HeartFrequency.MaxValue,
                false));

            this.deviceData = newData;

            return newData;
        }

        private double GenerateDoubleValue(double value, double delta, double minValue, double maxValue)
        {
            double newValue = value + ((this.random.NextDouble() * (2 * delta )) - delta);

            newValue = newValue <= minValue ? minValue : newValue;
            newValue = newValue >= maxValue ? maxValue : newValue;

            return newValue;
        }

        private int GenerateIntValue(int value, int delta, int minValue, int maxValue, bool canIncrease)
        {
            int maxRandomValue = 2;

            if (canIncrease)
            {
                maxRandomValue = 1;
            }

            int newValue = value + (this.random.Next(-1, maxRandomValue) * delta);

            newValue = newValue <= minValue ? minValue : newValue;
            newValue = newValue >= maxValue ? maxValue : newValue;

            return newValue;
        }
    }
}
