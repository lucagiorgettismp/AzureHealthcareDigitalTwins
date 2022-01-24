namespace Simulator.Simulator.Model
{
    class DeviceDataProperty
    {
        public object Value { get; set; }
        
        public bool InAlarm { get; set; }
        
        public string UnitOfMeasurement { get; set; }
        
        public object MinValue { get; set; }
        
        public object MaxValue { get; set; }
        
        public object AlarmMinThreashold { get; set; }

        public object AlarmMaxThreashold { get; set; }
        
        public object UpdateDelta { get; set; }
    }
}
