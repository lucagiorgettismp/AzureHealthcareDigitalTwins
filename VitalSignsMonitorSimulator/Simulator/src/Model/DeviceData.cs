namespace Simulator.Model
{
    public class DeviceData
    {
        public DeviceDataPropertyMinMaxThreshold<double> Temperature { get; set; }
        
        public DeviceDataPropertyMinMaxThreshold<int> BloodPressure { get; set; }
        
        public DeviceDataPropertyMinThreshold<int> Saturation { get; set; }
        
        public DeviceDataPropertyMinMaxThreshold<int> BreathFrequency { get; set; }
        
        public DeviceDataPropertyMinMaxThreshold<int> HeartFrequency { get; set; }
        
        public DeviceDataPropertyMinThreshold<int> BatteryPower { get; set; }
    }
}
