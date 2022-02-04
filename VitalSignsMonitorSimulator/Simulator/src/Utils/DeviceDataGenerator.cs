namespace Simulator.Utils
{
    using Common.Utils;
    using Model;
    using System;

    class DeviceDataGenerator
    {
        private DeviceData deviceData;

        private const string CELSIUS = "Celsius";
        private const string PERCENTAGE = "Percentage";
        private const string mmHg = "mmHg";
        private const string BPM = "bpm";
        private const string RPM = "rpm";

        public const int MIN_TEMPERATURE = 35;
        public const int MAX_TEMPERATURE = 45;

        public const int MIN_SATURATION = 60;
        public const int MAX_SATURATION = 100;

        public const int MIN_HEART = 40;
        public const int MAX_HEART = 140;

        public const int MIN_BREATH = 6;
        public const int MAX_BREATH = 30;

        public const int MIN_BLOOD_PRESSURE = 60;
        public const int MAX_BLOOD_PRESSURE = 160;

        public const int MIN_BATTERY = 0;
        public const int MAX_BATTERY = 100;


        public DeviceDataGenerator()
        {
            deviceData = new DeviceData
            {
                Temperature = new DeviceDataProperty<Double>
                {
                    UnitOfMeasurement = CELSIUS,
                    MinValue = MIN_TEMPERATURE,
                    MaxValue = MAX_TEMPERATURE,
                    Value = 36.6,
                    AlarmMinThreashold = 36.4,
                    AlarmMaxThreashold = 37.2,
                    InAlarm = false,
                    UpdateDelta = 0.3,
                },
                BatteryPower = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = PERCENTAGE,
                    MinValue = MIN_BATTERY,
                    MaxValue = MAX_BATTERY,
                    Value = 100,
                    AlarmMinThreashold = 20,
                    AlarmMaxThreashold = 100,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                BloodPressure = new DeviceDataProperty<Int32> {
                    UnitOfMeasurement = mmHg,
                    MinValue = MIN_BLOOD_PRESSURE,
                    MaxValue = MAX_BLOOD_PRESSURE,
                    Value = 115,
                    AlarmMinThreashold = 90,
                    AlarmMaxThreashold = 140,
                    InAlarm = false,
                    UpdateDelta = 1,
                },

                BreathFrequency = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = RPM,
                    MinValue = MIN_BREATH,
                    MaxValue = MAX_BREATH,
                    Value = 14,
                    AlarmMinThreashold = 12,
                    AlarmMaxThreashold = 20,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                HeartFrequency = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = BPM,
                    MinValue = MIN_HEART,
                    MaxValue = MAX_HEART,
                    Value = 80,
                    AlarmMinThreashold = 60,
                    AlarmMaxThreashold = 100,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                Saturation = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = PERCENTAGE,
                    MinValue = MIN_SATURATION,
                    MaxValue = MAX_SATURATION,
                    Value = 98,
                    AlarmMinThreashold = 95,
                    AlarmMaxThreashold = 100,
                    InAlarm = false,
                    UpdateDelta = 1,
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
            var random = new Random();
            var delta = (double)dataProperty.UpdateDelta;

            var newValue = oldValue + random.NextDouble() * (2 * delta ) - delta;
            if (newValue < (double)dataProperty.MinValue)
                newValue = (double)dataProperty.MinValue;
            
            if (newValue > (double)dataProperty.MaxValue)
                newValue = (double)dataProperty.MaxValue;
           
            dataProperty.InAlarm = newValue <= (double)dataProperty.AlarmMinThreashold || newValue >= (double)dataProperty.AlarmMaxThreashold;
            dataProperty.Value = newValue;

            return dataProperty;
        }
        private DeviceDataProperty<int> GenerateIntValue(DeviceDataProperty<int> dataProperty, bool isBattery)
        {
            var oldValue = dataProperty.Value;
            var random = new Random();
            var delta = dataProperty.UpdateDelta;

            int maxValue = 2;
            if (isBattery)maxValue = 1;
         

            var newValue = oldValue + random.Next(-1, maxValue) * delta;
            if (newValue < dataProperty.MinValue)
                newValue = dataProperty.MinValue;
            
            if (newValue > dataProperty.MaxValue)
                newValue = dataProperty.MaxValue;

            dataProperty.InAlarm = newValue <= dataProperty.AlarmMinThreashold || newValue >= (double)dataProperty.AlarmMaxThreashold;
            dataProperty.Value = newValue;

            return dataProperty;
        }
    }
}
