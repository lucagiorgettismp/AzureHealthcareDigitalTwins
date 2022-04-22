using Common.Utils.Exceptions;

namespace Simulator.Model
{
    public class DeviceDataPropertyMinMaxThreshold<T> : DeviceDataPropertyMinThreshold<T>
    {

        /// <exception cref="InvalidPropertyTypeException"/>
        internal void SetValue(T value) {
            this.Value = value;
            this.InAlert = CheckMinThresholdAlert(value, this.MinAlertThreashold) || CheckMaxThresholdAlert(this.Value, this.MaxAlertThreshold);
        }

        public T MaxAlertThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="InvalidPropertyTypeException"></exception>
        /// <returns></returns>
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
