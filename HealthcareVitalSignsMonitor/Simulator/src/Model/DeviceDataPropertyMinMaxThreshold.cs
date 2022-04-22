using Common.Utils.Exceptions;

namespace Simulator.Model
{
    using Common.Utils.Exceptions;

    public class DeviceDataPropertyMinMaxThreshold<T> : DeviceDataPropertyMinThreshold<T>
    {

        /// <exception cref="InvalidPropertyTypeException"/>
        internal void SetValue(T value) {
            this.Value = value;
            this.InAlert = CheckMinThresholdAlert(value, this.MinAlertThreshold) || CheckMaxThresholdAlert(this.Value, this.MaxAlertThreshold);
        }

        public T MaxAlertThreshold { get; set; }
        
        /// <exception cref="InvalidPropertyTypeException"/>
        private static bool CheckMaxThresholdAlert(T value, T threshold)
        {
            if (value is int && threshold is int)
            {
                return (int)(object)value >= (int)(object)threshold;
            }

            if (value is double && threshold is double)
            {
                return (double)(object)value >= (double)(object)threshold;
            }

            throw new InvalidPropertyTypeException();
        }
    }
}
