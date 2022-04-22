namespace Simulator.Model
{
    public class DeviceDataProperty<T>
    {
        public T Value { get; protected set; }
         
        public string UnitOfMeasurement { get; set; }

        public string SensorName{ get; set; }
        
        public T MinValue { get; set; }
        
        public T MaxValue { get; set; }

        public string GraphColor { get; set; }

        public bool InAlert { get; internal set; }

        public T UpdateDelta { get; set; }

        public string Type { get; set; }
    }
}
