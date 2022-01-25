namespace Simulator.Simulator.Model
{
    class DeviceData
    {
        public DeviceDataProperty<double> Temperature { get; set; }
        
        public DeviceDataProperty<int> BloodPressure { get; set; }
        
        public DeviceDataProperty<int> Saturation { get; set; }
        
        public DeviceDataProperty<int> BreathFrequency { get; set; }
        
        public DeviceDataProperty<int> HeartFrequency { get; set; }
        
        public DeviceDataProperty<int> BatteryPower { get; set; }
    }
}
