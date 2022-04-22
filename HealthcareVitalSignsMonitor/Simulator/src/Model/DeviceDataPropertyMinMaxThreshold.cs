namespace Simulator.Model
{
    using Utils.Exceptions;
    public class DeviceDataPropertyMinMaxThreshold<T> : DeviceDataPropertyMinThreshold<T>
    {
        internal void SetValue(T value) {
            this.Value = value;
            this.InAlert = CheckMinThresholdAlert(value, this.MinAlertThreashold) || CheckMaxThresholdAlert(this.Value, this.MaxAlertThreshold);
        }

        public T MaxAlertThreshold { get; set; }

        private static bool CheckMaxThresholdAlert(T value, T threshold)
        {
            if (value is int && threshold is int)
            {
                return (int)(object)value >= (int)(object)threshold;
            }
            else if (value is double && threshold is double)
            {
                return (double)(object)value >= (double)(object)threshold;
            }
            else
            {
                throw new InvalidPropertyTypeException();
            }
        }
    }
}
