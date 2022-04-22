using Common.Utils.Exceptions;

namespace Simulator.Model
{
    using Common.Utils.Exceptions;

    public class DeviceDataPropertyMinThreshold<T> : DeviceDataProperty<T>
    {
        internal void SetValue(T value)
        {
            this.Value = value;
            this.InAlert = CheckMinThresholdAlert(value, this.MinAlertThreshold);
        }

        public T MinAlertThreshold { get; set; }

        /// <exception cref="InvalidPropertyTypeException"/>
        protected bool CheckMinThresholdAlert(T value, T threshold)
        {
            if (value is int && threshold is int)
            {
                return (int)(object)value <= (int)(object)threshold;
            }

            if (value is double && threshold is double)
            {
                return (double)(object)value <= (double)(object)threshold;
            }

            throw new InvalidPropertyTypeException();
        }
    }
}
