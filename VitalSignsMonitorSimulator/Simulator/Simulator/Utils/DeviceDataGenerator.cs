namespace Simulator.Simulator.Model
{
    using System;

    class DeviceDataGenerator
    {
        private DeviceData deviceData;

        private const string CELSIUS = "Celsius";
        private const string PERCENTAGE = "Percentage";
        private const string mmHg = "mmHg";
        private const string BPM = "bpm";
        private const string RPM = "rpm";

        public DeviceDataGenerator()
        {
            deviceData = new DeviceData
            {
                Temperature = new DeviceDataProperty<Double>
                {
                    UnitOfMeasurement = CELSIUS,
                    MinValue = 35,
                    MaxValue = 45,
                    Value = 36.6,
                    AlarmMinThreashold = 36.4,
                    AlarmMaxThreashold = 37.2,
                    InAlarm = false,
                    UpdateDelta = 0.3,
                },
                BatteryPower = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = PERCENTAGE,
                    MinValue = 0,
                    MaxValue = 100,
                    Value = 50,
                    AlarmMinThreashold = 20,
                    AlarmMaxThreashold = 100,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                BloodPressure = new DeviceDataProperty<Int32> {
                    UnitOfMeasurement = mmHg,
                    MinValue = 60,
                    MaxValue = 160,
                    Value = 115,
                    AlarmMinThreashold = 90,
                    AlarmMaxThreashold = 140,
                    InAlarm = false,
                    UpdateDelta = 1,
                },

                BreathFrequency = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = RPM,
                    MinValue = 6,
                    MaxValue = 30,
                    Value = 14,
                    AlarmMinThreashold = 12,
                    AlarmMaxThreashold = 20,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                HeartFrequency = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = BPM,
                    MinValue = 40,
                    MaxValue = 140,
                    Value = 80,
                    AlarmMinThreashold = 60,
                    AlarmMaxThreashold = 100,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                Saturation = new DeviceDataProperty<Int32>
                {
                    UnitOfMeasurement = PERCENTAGE,
                    MinValue = 60,
                    MaxValue = 100,
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
                BloodPressure = this.GenerateIntValue(deviceData.BloodPressure),
                BatteryPower = this.GenerateIntValue(deviceData.BatteryPower),
                Saturation = this.GenerateIntValue(deviceData.Saturation),
                BreathFrequency = this.GenerateIntValue(deviceData.BreathFrequency),
                HeartFrequency = this.GenerateIntValue(deviceData.HeartFrequency)
            };

            this.deviceData = newData;

            return newData;
        }

        private DeviceDataProperty<double> GenerateDoubleValue(DeviceDataProperty<double> dataProperty)
        {
            var oldValue = dataProperty.Value;
            var random = new Random();
            var delta = (double)dataProperty.UpdateDelta;

            var newValue = oldValue + random.NextDouble() * (2 * delta) - delta;
            if (newValue < (double)dataProperty.MinValue)
            {
                newValue = (double)dataProperty.MinValue;
            }

            if (newValue > (double)dataProperty.MaxValue)
            {
                newValue = (double)dataProperty.MaxValue;
            }

            dataProperty.InAlarm = newValue <= (double)dataProperty.AlarmMinThreashold || newValue >= (double)dataProperty.AlarmMaxThreashold;
            dataProperty.Value = newValue;

            return dataProperty;
        }
        private DeviceDataProperty<int> GenerateIntValue(DeviceDataProperty<int> dataProperty)
        {
            var oldValue = dataProperty.Value;
            var random = new Random();
            var delta = dataProperty.UpdateDelta;

            var newValue = oldValue + random.Next() * (2 * delta) - delta;
            if (newValue < dataProperty.MinValue)
            {
                newValue = dataProperty.MinValue;
            }

            if (newValue > dataProperty.MaxValue)
            {
                newValue = dataProperty.MaxValue;
            }

            dataProperty.InAlarm = newValue <= dataProperty.AlarmMinThreashold || newValue >= (double)dataProperty.AlarmMaxThreashold;
            dataProperty.Value = newValue;

            return dataProperty;
        }
    }
}
