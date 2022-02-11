namespace Simulator.Utils
{
    using Model;
    using System;

    class DeviceDataGenerator
    {
        private DeviceData deviceData;

        // Sensor name
        private const string TEMPERATURE = "Temperature";
        private const string BLOOD_PRESSURE = "Blood Pressure";
        private const string SATURATION = "Saturation";
        private const string HEART_FREQUENCY = "Heart Frequency";
        private const string BREATH_FREQUENCY = "Breath Frequency";
        private const string BATTERY = "Battery";

        // Unit of measurement
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

        /** Temperature **/
        public const double MIN_TEMPERATURE = 35;
        public const double MAX_TEMPERATURE = 45;
        public const double ALARM_MIN_TEMPERATURE = 36.4;
        public const double ALARM_MAX_TEMPERATURE = 37.2;

        /** Saturation **/
        public const int MIN_SATURATION = 60;
        public const int MAX_SATURATION = 100;
        public const int ALARM_MIN_SATURATION = 95;
        public const int ALARM_MAX_SATURATION = 100;

        /** Heart Frequency **/
        public const int MIN_HEART = 40;
        public const int MAX_HEART = 140;
        public const int ALARM_MIN_HEART = 60;
        public const int ALARM_MAX_HEART = 100;

        /** Breath frequency **/
        public const int MIN_BREATH = 6;
        public const int MAX_BREATH = 30;
        public const int ALARM_MIN_BREATH = 12;
        public const int ALARM_MAX_BREATH = 20;

        /** Blood Pressure **/
        public const int MIN_BLOOD_PRESSURE = 60;
        public const int MAX_BLOOD_PRESSURE = 160;
        public const int ALARM_MIN_BLOOD_PRESSURE = 90;
        public const int ALARM_MAX_BLOOD_PRESSURE = 140;

        /** Battery **/
        public const int MIN_BATTERY = 0;
        public const int MAX_BATTERY = 100;
        public const int ALARM_MIN_BATTERY = 20;
        public const int ALARM_MAX_BATTERY = 100;

        private readonly Random random = new Random();

        public DeviceDataGenerator()
        {
            deviceData = new DeviceData
            {
                Temperature = new DeviceDataProperty<Double>
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
                BatteryPower = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = UNIT_PERCENTAGE,
                    MinValue = MIN_BATTERY,
                    MaxValue = MAX_BATTERY,
                    Value = 100,
                    AlarmMinThreashold = ALARM_MIN_BATTERY,
                    AlarmMaxThreashold = ALARM_MAX_BATTERY,
                    InAlarm = false,
                    UpdateDelta = 1,
                    SensorName = BATTERY,
                    Symbol = SYMBOL_PERCENTAGE,
                    Type = TYPE_INT
                },
                BloodPressure = new DeviceDataProperty<Int32> {
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

                BreathFrequency = new DeviceDataProperty<Int32>
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
                HeartFrequency = new DeviceDataProperty<Int32>
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
                Saturation = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = UNIT_PERCENTAGE,
                    MinValue = MIN_SATURATION,
                    MaxValue = MAX_SATURATION,
                    Value = 98,
                    AlarmMinThreashold = ALARM_MIN_SATURATION,
                    AlarmMaxThreashold = ALARM_MAX_SATURATION,
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
            var newData = new DeviceData
            {
                Temperature = this.GenerateDoubleValue(deviceData.Temperature),
                BloodPressure = this.GenerateIntValue(deviceData.BloodPressure, false),
                BatteryPower = this.GenerateIntValue(deviceData.BatteryPower, true),
                Saturation = this.GenerateIntValue(deviceData.Saturation, false),
                BreathFrequency = this.GenerateIntValue(deviceData.BreathFrequency, false),
                HeartFrequency = this.GenerateIntValue(deviceData.HeartFrequency, false)
            };

            this.deviceData = newData;

            return newData;
        }

        private DeviceDataProperty<double> GenerateDoubleValue(DeviceDataProperty<double> dataProperty)
        {
            var oldValue = dataProperty.Value;
            var delta = (double)dataProperty.UpdateDelta;

            var newValue = oldValue + this.random.NextDouble() * (2 * delta ) - delta;
            if (newValue < (double)dataProperty.MinValue)
                newValue = (double)dataProperty.MinValue;

            else if (newValue > (double)dataProperty.MaxValue)
                newValue = (double)dataProperty.MaxValue;
           
            dataProperty.InAlarm = newValue <= (double)dataProperty.AlarmMinThreashold || newValue >= (double)dataProperty.AlarmMaxThreashold;
            dataProperty.Value = newValue;

            return dataProperty;
        }
        private DeviceDataProperty<int> GenerateIntValue(DeviceDataProperty<int> dataProperty, bool canIncrease)
        {
            var oldValue = dataProperty.Value;
            var delta = dataProperty.UpdateDelta;
            int maxValue = 2;

            if (!canIncrease) maxValue = 1;
         
            var newValue = oldValue + this.random.Next(-1, maxValue) * delta;

            if (newValue < dataProperty.MinValue)
                newValue = dataProperty.MinValue;
            
            else if (newValue > dataProperty.MaxValue)
                newValue = dataProperty.MaxValue;

            dataProperty.InAlarm = newValue <= dataProperty.AlarmMinThreashold || newValue >= (double)dataProperty.AlarmMaxThreashold;
            dataProperty.Value = newValue;

            return dataProperty;
        }
    }
}
