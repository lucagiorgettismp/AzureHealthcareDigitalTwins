namespace Simulator.Model
{
    public class DeviceDataProperty<T>
    {
        public T Value { get; protected set; }
         
        public string UnitOfMeasurement { get; set; }

        public string Symbol { get; set; }

        public string SensorName{ get; set; }
        
        public T MinValue { get; set; }
        
        public T MaxValue { get; set; }

        public string GraphColor { get; set; }

        public bool InAlarm { get; internal set; }

        public T UpdateDelta { get; set; }

        public string Type { get; set; }
    }
}
