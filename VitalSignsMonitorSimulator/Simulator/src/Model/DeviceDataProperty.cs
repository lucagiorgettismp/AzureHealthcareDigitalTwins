namespace Model
{
    class DeviceDataProperty<T>
    {
        public T Value { get; set; }
        
        public bool InAlarm { get; set; }
        
        public string UnitOfMeasurement { get; set; }
        
        public T MinValue { get; set; }
        
        public T MaxValue { get; set; }
        
        public T AlarmMinThreashold { get; set; }

        public T AlarmMaxThreashold { get; set; }
        
        public T UpdateDelta { get; set; }
    }
}
