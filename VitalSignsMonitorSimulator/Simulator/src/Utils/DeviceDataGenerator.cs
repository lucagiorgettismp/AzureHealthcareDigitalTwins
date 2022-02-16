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

            var appSettings = ConfigurationManager.AppSettings;


            deviceData = new DeviceData
            {
                Temperature = new DeviceDataPropertyMinMaxThreshold<double>
                {
                    UnitOfMeasurement = appSettings["TemperatureUnit"],
                    MinValue = Convert.ToDouble(appSettings["TemperatureMinValue"]),
                    MaxValue = Convert.ToDouble(appSettings["TemperatureMaxValue"]),
                    Value = Convert.ToDouble(appSettings["TemperatureInitValue"]),
                    AlarmMinThreashold = Convert.ToDouble(appSettings["TemperatureMinAlarmThreasholdValue"]),
                    AlarmMaxThreashold = Convert.ToDouble(appSettings["TemperatureMaxAlarmThreasholdValue"]),
                    UpdateDelta = Convert.ToDouble(appSettings["TemperatureUpdateDelta"]),
                    SensorName = appSettings["TemperatureSensorName"],
                    Symbol = appSettings["TemperatureUnitSymbol"],
                    Type = DoubleType,
                    InAlarm = false
                },
                BatteryPower = new DeviceDataPropertyMinThreshold<int>
                {
                    UnitOfMeasurement = appSettings["BatteryUnit"],
                    MinValue = Convert.ToInt32(appSettings["BatteryMinValue"]),
                    MaxValue = Convert.ToInt32(appSettings["BatteryMaxValue"]),
                    Value = Convert.ToInt32(appSettings["BatteryInitValue"]),
                    AlarmMinThreashold = Convert.ToInt32(appSettings["BatteryMinAlarmThreasholdValue"]),
                    UpdateDelta = Convert.ToInt32(appSettings["BatteryUpdateDelta"]),
                    SensorName = appSettings["BatterySensorName"],
                    Symbol = appSettings["BatteryUnitSymbol"],
                    Type = IntType,
                    InAlarm = false
                },
                BloodPressure = new DeviceDataPropertyMinMaxThreshold<int> {
                    UnitOfMeasurement = appSettings["BloodPressureUnit"],
                    MinValue = Convert.ToInt32(appSettings["BloodPressureMinValue"]),
                    MaxValue = Convert.ToInt32(appSettings["BloodPressureMaxValue"]),
                    Value = Convert.ToInt32(appSettings["BloodPressureInitValue"]),
                    AlarmMinThreashold = Convert.ToInt32(appSettings["BloodPressureMinAlarmThreasholdValue"]),
                    AlarmMaxThreashold = Convert.ToInt32(appSettings["BloodPressureMaxAlarmThreasholdValue"]),
                    UpdateDelta = Convert.ToInt32(appSettings["BloodPressureUpdateDelta"]),
                    SensorName = appSettings["BloodPressureSensorName"],
                    Symbol = appSettings["BloodPressureUnitSymbol"],
                    Type = IntType,
                    InAlarm = false
                },

                BreathFrequency = new DeviceDataPropertyMinMaxThreshold<int>
                {
                    UnitOfMeasurement = appSettings["BreathFrequencyUnit"],
                    MinValue = Convert.ToInt32(appSettings["BreathFrequencyMinValue"]),
                    MaxValue = Convert.ToInt32(appSettings["BreathFrequencyMaxValue"]),
                    Value = Convert.ToInt32(appSettings["BreathFrequencyInitValue"]),
                    AlarmMinThreashold = Convert.ToInt32(appSettings["BreathFrequencyMinAlarmThreasholdValue"]),
                    AlarmMaxThreashold = Convert.ToInt32(appSettings["BreathFrequencyMaxAlarmThreasholdValue"]),
                    UpdateDelta = Convert.ToInt32(appSettings["BreathFrequencyUpdateDelta"]),
                    SensorName = appSettings["BreathFrequencySensorName"],
                    Symbol = appSettings["BreathFrequencyUnitSymbol"],
                    Type = IntType,
                    InAlarm = false
                },
                HeartFrequency = new DeviceDataPropertyMinMaxThreshold<int>
                {
                    UnitOfMeasurement = appSettings["HeartFrequencyUnit"],
                    MinValue = Convert.ToInt32(appSettings["HeartFrequencyMinValue"]),
                    MaxValue = Convert.ToInt32(appSettings["HeartFrequencyMaxValue"]),
                    Value = Convert.ToInt32(appSettings["HeartFrequencyInitValue"]),
                    AlarmMinThreashold = Convert.ToInt32(appSettings["HeartFrequencyMinAlarmThreasholdValue"]),
                    AlarmMaxThreashold = Convert.ToInt32(appSettings["HeartFrequencyMaxAlarmThreasholdValue"]),
                    UpdateDelta = Convert.ToInt32(appSettings["HeartFrequencyUpdateDelta"]),
                    SensorName = appSettings["HeartFrequencySensorName"],
                    Symbol = appSettings["HeartFrequencyUnitSymbol"],
                    Type = IntType,
                    InAlarm = false
                },
                Saturation = new DeviceDataPropertyMinThreshold<int>
                {
                    UnitOfMeasurement = appSettings["SaturationUnit"],
                    MinValue = Convert.ToInt32(appSettings["SaturationMinValue"]),
                    MaxValue = Convert.ToInt32(appSettings["SaturationMaxValue"]),
                    Value = Convert.ToInt32(appSettings["SaturationInitValue"]),
                    AlarmMinThreashold = Convert.ToInt32(appSettings["SaturationMinAlarmThreasholdValue"]),
                    UpdateDelta = Convert.ToInt32(appSettings["SaturationUpdateDelta"]),
                    SensorName = appSettings["SaturationSensorName"],
                    Symbol = appSettings["SaturationUnitSymbol"],
                    Type = IntType,
                    InAlarm = false
                },
            };
        }

        public DeviceData GetUpdatedDeviceData()
        {
            var newData = this.deviceData;

            newData.Temperature.Value = this.GenerateDoubleValue(
                (double)(object)deviceData.Temperature.Value,
                (double)(object)deviceData.Temperature.UpdateDelta,
                (double)(object)deviceData.Temperature.MinValue,
                (double)(object)deviceData.Temperature.MaxValue);

            newData.BloodPressure.Value = this.GenerateIntValue(
                deviceData.BloodPressure.Value,
                deviceData.BloodPressure.UpdateDelta,
                deviceData.BloodPressure.MinValue,
                deviceData.BloodPressure.MaxValue, 
                false);

            newData.BatteryPower.Value = this.GenerateIntValue(
                deviceData.BatteryPower.Value,
                deviceData.BatteryPower.UpdateDelta,
                deviceData.BatteryPower.MinValue,
                deviceData.BatteryPower.MaxValue,
                true);

            newData.Saturation.Value = this.GenerateIntValue(
                deviceData.Saturation.Value,
                deviceData.Saturation.UpdateDelta,
                deviceData.Saturation.MinValue,
                deviceData.Saturation.MaxValue,
                false);

            newData.BreathFrequency.Value = this.GenerateIntValue(
                deviceData.BreathFrequency.Value,
                deviceData.BreathFrequency.UpdateDelta,
                deviceData.BreathFrequency.MinValue,
                deviceData.BreathFrequency.MaxValue,
                false);

            newData.HeartFrequency.Value = this.GenerateIntValue(
                deviceData.HeartFrequency.Value,
                deviceData.HeartFrequency.UpdateDelta,
                deviceData.HeartFrequency.MinValue,
                deviceData.HeartFrequency.MaxValue,
                false);

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
