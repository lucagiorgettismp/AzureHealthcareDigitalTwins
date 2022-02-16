namespace Simulator.Model
{
    public class DeviceDataProperty<T>
    {
        public T Value { get; set; }
         
        public string UnitOfMeasurement { get; set; }

        public string Symbol { get; set; }

        public string SensorName{ get; set; }
        
        public T MinValue { get; set; }
        
        public T MaxValue { get; set; }

        public bool InAlarm { get
            {
                return false;
            }

            set { }
        }

        public T UpdateDelta { get; set; }

        public string Type { get; set; }
    }
}
