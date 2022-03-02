﻿namespace Simulator.Model
{
    using Simulator.Utils.Exceptions;
    public class DeviceDataPropertyMinMaxThreshold<T> : DeviceDataPropertyMinThreshold<T>
    {
        internal void SetValue(T value) {
            this.Value = value;
            this.InAlarm = CheckMinThresholdAlarm(value, this.AlarmMinThreashold) || CheckMaxThresholdAlarm(this.Value, this.AlarmMaxThreashold);
        }

        public T AlarmMaxThreashold { get; set; }

        private bool CheckMaxThresholdAlarm(T ta, T tb)
        {
            if (ta is int && tb is int)
            {
                return (int)(object)ta >= (int)(object)tb;
            }
            else if (ta is double && tb is double)
            {
                return (double)(object)ta >= (double)(object)tb;
            }
            else
            {
                throw new InvalidPropertyTypeException();
            }
        }
    }
}