namespace Simulator.Utils
{
    using Model;
    using System;

    class DeviceDataGenerator
    {
        private DeviceData deviceData;

        /* Sensor name */
        private const string TEMPERATURE = "Temperature";
        private const string BLOOD_PRESSURE = "Blood Pressure";
        private const string SATURATION = "Saturation";
        private const string HEART_FREQUENCY = "Heart Frequency";
        private const string BREATH_FREQUENCY = "Breath Frequency";
        private const string BATTERY = "Battery";

        /* Unit of measurement */
        private const string UNIT_CELSIUS = "Celsius";
        private const string UNIT_PERCENTAGE = "Percentage";
        private const string UNIT_BLOOD_PRESSURE = "Millimeters of mercury";
        private const string UNIT_BREATH_FREQUENCY = "Revolutions per minute";
        private const string UNIT_HEART_FREQUENCY = "Beats per minute";

        private const string SYMBOL_TEMPERATURE = "°C";
        private const string SYMBOL_PERCENTAGE = "%";
        private const string SYMBOL_BLOOD_PRESSURE = "mmHg";
        private const string SYMBOL_HEART_FREQUENCY = "bpm";
        private const string SYMBOL_BREATH_FREQUENCY = "rpm";

        private const string TYPE_INT = "int";
        private const string TYPE_DOUBLE = "double";

        // Sensor range and threshold

        /* Temperature */
        public const double MIN_TEMPERATURE = 35;
        public const double MAX_TEMPERATURE = 45;
        public const double ALARM_MIN_TEMPERATURE = 36.4;
        public const double ALARM_MAX_TEMPERATURE = 37.2;

        /* Saturation */
        public const int MIN_SATURATION = 60;
        public const int MAX_SATURATION = 100;
        public const int ALARM_MIN_SATURATION = 95;

        /* Heart Frequency */
        public const int MIN_HEART = 40;
        public const int MAX_HEART = 140;
        public const int ALARM_MIN_HEART = 60;
        public const int ALARM_MAX_HEART = 100;

        /* Breath frequency */
        public const int MIN_BREATH = 6;
        public const int MAX_BREATH = 30;
        public const int ALARM_MIN_BREATH = 12;
        public const int ALARM_MAX_BREATH = 20;

        /* Blood Pressure */
        public const int MIN_BLOOD_PRESSURE = 60;
        public const int MAX_BLOOD_PRESSURE = 160;
        public const int ALARM_MIN_BLOOD_PRESSURE = 90;
        public const int ALARM_MAX_BLOOD_PRESSURE = 140;

        /* Battery */
        public const int MIN_BATTERY = 0;
        public const int MAX_BATTERY = 100;
        public const int ALARM_MIN_BATTERY = 20;

        private readonly Random random = new Random();

        public DeviceDataGenerator()
        {
            deviceData = new DeviceData
            {
                Temperature = new DeviceDataPropertyMinMaxThreshold<Double>
                {
                    UnitOfMeasurement = UNIT_CELSIUS,
                    MinValue = MIN_TEMPERATURE,
                    MaxValue = MAX_TEMPERATURE,
                    Value = 36.6,
                    AlarmMinThreashold = ALARM_MIN_TEMPERATURE,
                    AlarmMaxThreashold = ALARM_MAX_TEMPERATURE,
                    InAlarm = false,
                    UpdateDelta = 0.3,
                    SensorName = TEMPERATURE,
                    Symbol = SYMBOL_TEMPERATURE,
                    Type = TYPE_DOUBLE
                },
                BatteryPower = new DeviceDataPropertyMinThreshold<Int32>
                {
                    UnitOfMeasurement = UNIT_PERCENTAGE,
                    MinValue = MIN_BATTERY,
                    MaxValue = MAX_BATTERY,
                    Value = 100,
                    AlarmMinThreashold = ALARM_MIN_BATTERY,
                    InAlarm = false,
                    UpdateDelta = 1,
                    SensorName = BATTERY,
                    Symbol = SYMBOL_PERCENTAGE,
                    Type = TYPE_INT
                },
                BloodPressure = new DeviceDataPropertyMinMaxThreshold<Int32> {
                    UnitOfMeasurement = UNIT_BLOOD_PRESSURE,
                    MinValue = MIN_BLOOD_PRESSURE,
                    MaxValue = MAX_BLOOD_PRESSURE,
                    Value = 115,
                    AlarmMinThreashold = ALARM_MIN_BLOOD_PRESSURE,
                    AlarmMaxThreashold = ALARM_MAX_BLOOD_PRESSURE,
                    InAlarm = false,
                    UpdateDelta = 1,
                    SensorName = BLOOD_PRESSURE,
                    Symbol = SYMBOL_BLOOD_PRESSURE,
                    Type = TYPE_INT
                },

                BreathFrequency = new DeviceDataPropertyMinMaxThreshold<Int32>
                {
                    UnitOfMeasurement = UNIT_BREATH_FREQUENCY,
                    MinValue = MIN_BREATH,
                    MaxValue = MAX_BREATH,
                    Value = 14,
                    AlarmMinThreashold = ALARM_MIN_BREATH,
                    AlarmMaxThreashold = ALARM_MAX_BREATH,
                    InAlarm = false,
                    UpdateDelta = 1,
                    SensorName = BREATH_FREQUENCY,
                    Symbol = SYMBOL_BREATH_FREQUENCY,
                    Type = TYPE_INT
                },
                HeartFrequency = new DeviceDataPropertyMinMaxThreshold<Int32>
                {
                    UnitOfMeasurement = UNIT_HEART_FREQUENCY,
                    MinValue = MIN_HEART,
                    MaxValue = MAX_HEART,
                    Value = 80,
                    AlarmMinThreashold = ALARM_MIN_HEART,
                    AlarmMaxThreashold = ALARM_MAX_HEART,
                    InAlarm = false,
                    UpdateDelta = 1,
                    SensorName = HEART_FREQUENCY,
                    Symbol = SYMBOL_HEART_FREQUENCY,
                    Type = TYPE_INT
                },
                Saturation = new DeviceDataPropertyMinThreshold<Int32>
                {
                    UnitOfMeasurement = UNIT_PERCENTAGE,
                    MinValue = MIN_SATURATION,
                    MaxValue = MAX_SATURATION,
                    Value = 98,
                    AlarmMinThreashold = ALARM_MIN_SATURATION,
                    InAlarm = false,
                    UpdateDelta = 1,
                    SensorName = SATURATION,
                    Symbol = SYMBOL_PERCENTAGE,
                    Type = TYPE_INT
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
