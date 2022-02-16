namespace Simulator.Utils
{
    using Model;
    using System;
    using System.Configuration;

    class DeviceDataGenerator
    {
        private DeviceData deviceData;
        private readonly Random random;

        const string IntType = "int";
        const string DoubleType = "double";


        public DeviceDataGenerator()
        {

            random = new Random();

            InitDeviceData();
        }

        private void InitDeviceData()
        {
            var appSettings = ConfigurationManager.AppSettings;

            var temperature = new DeviceDataPropertyMinMaxThreshold<double>
            {
                UnitOfMeasurement = appSettings["TemperatureUnit"],
                MinValue = Convert.ToDouble(appSettings["TemperatureMinValue"]),
                MaxValue = Convert.ToDouble(appSettings["TemperatureMaxValue"]),
                AlarmMinThreashold = Convert.ToDouble(appSettings["TemperatureMinAlarmThreasholdValue"]),
                AlarmMaxThreashold = Convert.ToDouble(appSettings["TemperatureMaxAlarmThreasholdValue"]),
                UpdateDelta = Convert.ToDouble(appSettings["TemperatureUpdateDelta"]),
                SensorName = appSettings["TemperatureSensorName"],
                Symbol = appSettings["TemperatureUnitSymbol"],
                Type = DoubleType,
            };

            temperature.SetValue(Convert.ToDouble(appSettings["TemperatureInitValue"]));

            var batteryPower = new DeviceDataPropertyMinThreshold<int>
            {
                UnitOfMeasurement = appSettings["PercentageUnit"],
                MinValue = Convert.ToInt32(appSettings["BatteryMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BatteryMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["BatteryMinAlarmThreasholdValue"]),
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
                AlarmMinThreashold = Convert.ToInt32(appSettings["BloodPressureMinAlarmThreasholdValue"]),
                AlarmMaxThreashold = Convert.ToInt32(appSettings["BloodPressureMaxAlarmThreasholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["BloodPressureUpdateDelta"]),
                SensorName = appSettings["BloodPressureSensorName"],
                Symbol = appSettings["BloodPressureUnitSymbol"],
                Type = IntType,
            };
            bloodPressure.SetValue(Convert.ToInt32(appSettings["BloodPressureInitValue"]));

            var breathFrequency = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = appSettings["BreathFrequencyUnit"],
                MinValue = Convert.ToInt32(appSettings["BreathFrequencyMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BreathFrequencyMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["BreathFrequencyMinAlarmThreasholdValue"]),
                AlarmMaxThreashold = Convert.ToInt32(appSettings["BreathFrequencyMaxAlarmThreasholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["BreathFrequencyUpdateDelta"]),
                SensorName = appSettings["BreathFrequencySensorName"],
                Symbol = appSettings["BreathFrequencyUnitSymbol"],
                Type = IntType,
            };
            breathFrequency.SetValue(Convert.ToInt32(appSettings["BreathFrequencyInitValue"]));

            var heartFrequency = new DeviceDataPropertyMinMaxThreshold<int>
            {
                UnitOfMeasurement = appSettings["HeartFrequencyUnit"],
                MinValue = Convert.ToInt32(appSettings["HeartFrequencyMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["HeartFrequencyMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["HeartFrequencyMinAlarmThreasholdValue"]),
                AlarmMaxThreashold = Convert.ToInt32(appSettings["HeartFrequencyMaxAlarmThreasholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["HeartFrequencyUpdateDelta"]),
                SensorName = appSettings["HeartFrequencySensorName"],
                Symbol = appSettings["HeartFrequencyUnitSymbol"],
                Type = IntType,
            };
            heartFrequency.SetValue(Convert.ToInt32(appSettings["HeartFrequencyInitValue"]));

            var saturation = new DeviceDataPropertyMinThreshold<int>
            {
                UnitOfMeasurement = appSettings["PercentageUnit"],
                MinValue = Convert.ToInt32(appSettings["SaturationMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["SaturationMaxValue"]),
                AlarmMinThreashold = Convert.ToInt32(appSettings["SaturationMinAlarmThreasholdValue"]),
                UpdateDelta = Convert.ToInt32(appSettings["SaturationUpdateDelta"]),
                SensorName = appSettings["SaturationSensorName"],
                Symbol = appSettings["PercentageUnitSymbol"],
                Type = IntType,
                InAlarm = false
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
