﻿namespace Simulator.Utils
{
    using Model;
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

        public DeviceDataGenerator()
        {
            random = new Random();
            InitDeviceData();
        }

        private void InitDeviceData()
        {
            var appSettings = ConfigurationManager.AppSettings;

            double.TryParse(appSettings["TemperatureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMinValue);
            double.TryParse(appSettings["TemperatureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMaxValue);
            double.TryParse(appSettings["TemperatureMinAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMinAlarm);
            double.TryParse(appSettings["TemperatureMaxAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMaxAlarm);
            double.TryParse(appSettings["TemperatureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureUpdateDelta);
            double.TryParse(appSettings["TemperatureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureInitValue);

            var temperature = new DeviceDataPropertyMinMaxThreshold<double>
            {
                UnitOfMeasurement = appSettings["TemperatureUnit"],
                MinValue = temperatureMinValue,
                MaxValue = temperatureMaxValue,
                AlarmMinThreashold = temperatureMinAlarm,
                AlarmMaxThreashold = temperatureMaxAlarm,
                UpdateDelta = temperatureUpdateDelta,
                SensorName = appSettings["TemperatureSensorName"],
                Symbol = appSettings["TemperatureUnitSymbol"],
                Type = DoubleType,
            };

            temperature.SetValue(temperatureInitValue);

            var batteryPower = new DeviceDataPropertyMinThreshold<int>
            {
                UnitOfMeasurement = appSettings["PercentageUnit"],
                MinValue = Convert.ToInt32(appSettings["BatteryMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BatteryMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["BatteryMinAlarmThresholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["BatteryUpdateDelta"]),
                SensorName = appSettings["BatterySensorName"],
                Symbol = appSettings["PercentageUnitSymbol"],
                Type = IntType,
            };
            batteryPower.SetValue(Convert.ToInt32(appSettings["BatteryInitValue"]));

            var bloodPressure = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = appSettings["BloodPressureUnit"],
                MinValue = Convert.ToInt32(appSettings["BloodPressureMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BloodPressureMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["BloodPressureMinAlarmThresholdValue"]),
                AlarmMaxThreashold = Convert.ToInt32(appSettings["BloodPressureMaxAlarmThresholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["BloodPressureUpdateDelta"]),
                SensorName = appSettings["BloodPressureSensorName"],
                Symbol = appSettings["BloodPressureUnitSymbol"],
                Type = IntType,
                GraphColor = YELLOW
            };
            bloodPressure.SetValue(Convert.ToInt32(appSettings["BloodPressureInitValue"]));

            var breathFrequency = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = appSettings["BreathFrequencyUnit"],
                MinValue = Convert.ToInt32(appSettings["BreathFrequencyMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BreathFrequencyMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["BreathFrequencyMinAlarmThresholdValue"]),
                AlarmMaxThreashold = Convert.ToInt32(appSettings["BreathFrequencyMaxAlarmThresholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["BreathFrequencyUpdateDelta"]),
                SensorName = appSettings["BreathFrequencySensorName"],
                Symbol = appSettings["BreathFrequencyUnitSymbol"],
                Type = IntType,
                GraphColor = GREEN
            };
            breathFrequency.SetValue(Convert.ToInt32(appSettings["BreathFrequencyInitValue"]));

            var heartFrequency = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = appSettings["HeartFrequencyUnit"],
                MinValue = Convert.ToInt32(appSettings["HeartFrequencyMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["HeartFrequencyMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["HeartFrequencyMinAlarmThresholdValue"]),
                AlarmMaxThreashold = Convert.ToInt32(appSettings["HeartFrequencyMaxAlarmThresholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["HeartFrequencyUpdateDelta"]),
                SensorName = appSettings["HeartFrequencySensorName"],
                Symbol = appSettings["HeartFrequencyUnitSymbol"],
                Type = IntType,
                GraphColor = GREEN
            };
            heartFrequency.SetValue(Convert.ToInt32(appSettings["HeartFrequencyInitValue"]));

            var saturation = new DeviceDataPropertyMinThreshold<int>
            {
                UnitOfMeasurement = appSettings["PercentageUnit"],
                MinValue = Convert.ToInt32(appSettings["SaturationMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["SaturationMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["SaturationMinAlarmThresholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["SaturationUpdateDelta"]),
                SensorName = appSettings["SaturationSensorName"],
                Symbol = appSettings["PercentageUnitSymbol"],
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
            double newValue = value + this.random.NextDouble() * (2 * delta ) - delta;

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

            int newValue = value + this.random.Next(-1, maxRandomValue) * delta;

            newValue = newValue <= minValue ? minValue : newValue;
            newValue = newValue >= maxValue ? maxValue : newValue;

            return newValue;
        }
    }
}