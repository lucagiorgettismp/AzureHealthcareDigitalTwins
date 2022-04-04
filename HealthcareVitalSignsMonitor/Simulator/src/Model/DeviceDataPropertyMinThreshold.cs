namespace Simulator.Model
{
    using Simulator.Utils.Exceptions;

    public class DeviceDataPropertyMinThreshold<T> : DeviceDataProperty<T>
    {
        internal void SetValue(T value)
        {
            this.Value = value;
            this.InAlarm = CheckMinThresholdAlarm(value, this.MinAlertThreashold);
        }

        public T MinAlertThreashold { get; set; }

        protected bool CheckMinThresholdAlarm(T ta, T tb)
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
