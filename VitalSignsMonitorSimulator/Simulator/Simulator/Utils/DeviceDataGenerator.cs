namespace Simulator.Simulator.Model
{
    using System;

    class DeviceDataGenerator
    {
        private DeviceData deviceData;

        public DeviceDataGenerator()
        {
            deviceData = new DeviceData
            {
                Temperature = new DeviceDataProperty
                {
                    UnitOfMeasurement = "Celsius",
                    MinValue = (double) 35,
                    MaxValue = (double) 45,
                    Value = (double) 36.6,
                    AlarmMinThreashold = 36.4,
                    AlarmMaxThreashold = 37.2,
                    InAlarm = false,
                    UpdateDelta = (double) 0.3,
                },
                BatteryPower = new DeviceDataProperty
                {
                    UnitOfMeasurement = "Percentage",
                    MinValue = 0,
                    MaxValue = 100,
                    Value = 50,
                    AlarmMinThreashold = 20,
                    AlarmMaxThreashold = null,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                BloodPressure = new DeviceDataProperty {
                    UnitOfMeasurement = "mmHg",
                    MinValue = 60,
                    MaxValue = 160,
                    Value = 115,
                    AlarmMinThreashold = 90,
                    AlarmMaxThreashold = 140,
                    InAlarm = false,
                    UpdateDelta = 1,
                },

                BreathFrequency = new DeviceDataProperty
                {
                    UnitOfMeasurement = "rpm",
                    MinValue = 6,
                    MaxValue = 30,
                    Value = 14,
                    AlarmMinThreashold = 12,
                    AlarmMaxThreashold = 20,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
                HeartFrequency = new DeviceDataProperty
                {
                    UnitOfMeasurement = "bpm",
                    MinValue = 40,
                    MaxValue = 140,
                    Value = 80,
                    AlarmMinThreashold = 60,
                    AlarmMaxThreashold = 100,
                    InAlarm = false,
                    UpdateDelta = 0.5,
                },
                Saturation = new DeviceDataProperty
                {
                    UnitOfMeasurement = "Percentage",
                    MinValue = 60,
                    MaxValue = 100,
                    Value = 98,
                    AlarmMinThreashold = 95,
                    AlarmMaxThreashold = null,
                    InAlarm = false,
                    UpdateDelta = 1,
                },
            };
        }

        public DeviceData GetUpdatedDeviceData()
        {
            var newData = new DeviceData
            {
                Temperature = this.GenerateValue(deviceData.Temperature),
                BloodPressure = this.GenerateValue(deviceData.BloodPressure),
                BatteryPower = this.GenerateValue(deviceData.BatteryPower),
                Saturation = this.GenerateValue(deviceData.Saturation),
                BreathFrequency = this.GenerateValue(deviceData.BreathFrequency),
                HeartFrequency = this.GenerateValue(deviceData.HeartFrequency)
            };

            this.deviceData = newData;

            return newData;
        }

        private DeviceDataProperty GenerateValue(DeviceDataProperty dataProperty)
        {
            var oldValue = (double) dataProperty.Value;
            var random = new Random();
            var delta = (double) dataProperty.UpdateDelta;

            var newValue = oldValue + random.NextDouble() * (2 * delta ) - delta;
            if (newValue < (double) dataProperty.MinValue)
            {
                newValue = (double) dataProperty.MinValue;
            }

            if (newValue > (double)dataProperty.MaxValue)
            {
                newValue = (double)dataProperty.MaxValue;
            }

            dataProperty.InAlarm = newValue <= (double)dataProperty.AlarmMinThreashold || newValue >= (double)dataProperty.AlarmMaxThreashold;
            dataProperty.Value = dataProperty.Value is int ? newValue : (double)newValue;

            return dataProperty;
        }
    }
}
