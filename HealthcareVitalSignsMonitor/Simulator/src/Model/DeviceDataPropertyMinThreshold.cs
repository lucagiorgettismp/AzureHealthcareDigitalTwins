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
        protected bool CheckMinThresholdAlert(T ta, T tb)
        {
            if (ta is int && tb is int)
            {
                return (int)(object)ta <= (int)(object)tb;
            }
            else if (ta is double && tb is double)
            {
                return (double)(object)ta <= (double)(object)tb;
            }
            else
            {
                throw new InvalidPropertyTypeException();
            }
        }
    }
}
