using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simulator.Model;
using System;
using System.Configuration;
using System.Globalization;

namespace SimulatorTests
{
    [TestClass]
    public class DataGeneratedTests
    {
        private double TemperatureValue;
        private double TemperatureMinValue;
        private double TemperatureMaxValue;
        private double TemperatureUpdateDelta;

        private double HeartFrequencyValue;
        private double HeartFrequencyMinValue;
        private double HeartFrequencyMaxValue;
        private double HeartFrequencyUpdateDelta;

        private double BreathFrequencyValue;
        private double BreathFrequencyMinValue;
        private double BreathFrequencyMaxValue;
        private double BreathFrequencyUpdateDelta;

        private double SaturationValue;
        private double SaturationMinValue;
        private double SaturationMaxValue;
        private double SaturationUpdateDelta;

        private double BloodPressureValue;
        private double BloodPressureMinValue;
        private double BloodPressureMaxValue;
        private double BloodPressureUpdateDelta;

        private double BatteryValue;
        private double BatteryMinValue;
        private double BatteryMaxValue;
        private double BatteryUpdateDelta;

        [TestMethod]
        public void TestSensorsDataGenerated() {

            InitValue();
            
            TestTemperatureDataGenerated();
            TestHeartFrequencyDataGenerated();
            TestBreathFrequencyDataGenerated();
            TestSaturationDataGenerated();
            TestBloodPressureDataGenerated();
            TestBatteryDataGenerated();
        }

        private void InitValue()
        {
            var appSettings = ConfigurationManager.AppSettings;

            double.TryParse(appSettings["TemperatureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureValue);
            double.TryParse(appSettings["HeartFrequencyInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyValue);
            double.TryParse(appSettings["BreathFrequencyInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyValue);
            double.TryParse(appSettings["SaturationInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationValue);
            double.TryParse(appSettings["BloodPressureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureValue); 
            double.TryParse(appSettings["BatteryInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryValue);

            double.TryParse(appSettings["TemperatureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureUpdateDelta);
            double.TryParse(appSettings["TemperatureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMinValue);
            double.TryParse(appSettings["TemperatureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMaxValue);

            double.TryParse(appSettings["HeartFrequencyUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyUpdateDelta);
            double.TryParse(appSettings["HeartFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMinValue);
            double.TryParse(appSettings["HeartFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMaxValue);

            double.TryParse(appSettings["BreathFrequencyUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyUpdateDelta);
            double.TryParse(appSettings["BreathFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMinValue);
            double.TryParse(appSettings["BreathFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMaxValue);

            double.TryParse(appSettings["SaturationUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationUpdateDelta);
            double.TryParse(appSettings["SaturationMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationMinValue);
            double.TryParse(appSettings["SaturationMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationMaxValue);

            double.TryParse(appSettings["BloodPressureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureUpdateDelta);
            double.TryParse(appSettings["BloodPressureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMinValue);
            double.TryParse(appSettings["BloodPressureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMaxValue);

            double.TryParse(appSettings["BatteryUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryUpdateDelta);
            double.TryParse(appSettings["BatteryMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryMinValue);
            double.TryParse(appSettings["BatteryMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryMaxValue);
        }

        private void TestTemperatureDataGenerated()
        {
            Simulator.Utils.DeviceDataGenerator generator = new Simulator.Utils.DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue = deviceData.Temperature.Value;

            Console.WriteLine($"[Temperature] Init: {TemperatureValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(TemperatureValue, currentValue,
                TemperatureUpdateDelta, TemperatureMinValue, TemperatureMaxValue), "The temperature value was not generated correctly!");

            TemperatureValue = currentValue;
        }

        private void TestHeartFrequencyDataGenerated()
        {
            Simulator.Utils.DeviceDataGenerator generator = new Simulator.Utils.DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue = deviceData.HeartFrequency.Value;

            Console.WriteLine($"[Heart Frequency] Init: {HeartFrequencyValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(HeartFrequencyValue, currentValue,
                HeartFrequencyUpdateDelta, HeartFrequencyMinValue, HeartFrequencyMaxValue), "The heart frequency value was not generated correctly!");

            HeartFrequencyValue = currentValue;
        }

        private void TestBreathFrequencyDataGenerated()
        { 
            Simulator.Utils.DeviceDataGenerator generator = new Simulator.Utils.DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue = deviceData.BreathFrequency.Value;

            Console.WriteLine($"[Breath Frequency] Init: {BreathFrequencyValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(BreathFrequencyValue, currentValue,
                BreathFrequencyUpdateDelta, BreathFrequencyMinValue, BreathFrequencyMaxValue), "The breath frequency value was not generated correctly!");

            BreathFrequencyValue = currentValue;
        }

        private void TestSaturationDataGenerated()
        {
            Simulator.Utils.DeviceDataGenerator generator = new Simulator.Utils.DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue = deviceData.Saturation.Value;

            Console.WriteLine($"[Saturation] Init: {SaturationValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(SaturationValue, currentValue,
                SaturationUpdateDelta, SaturationMinValue, SaturationMaxValue), "The saturation value was not generated correctly!");

            SaturationValue = currentValue;
        }

        private void TestBloodPressureDataGenerated()
        {           
            Simulator.Utils.DeviceDataGenerator generator = new Simulator.Utils.DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue = deviceData.BloodPressure.Value;

            Console.WriteLine($"[Blood Pressure] Init: {BloodPressureValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(BloodPressureValue, currentValue,
                BloodPressureUpdateDelta, BloodPressureMinValue, BloodPressureMaxValue), "The blood Pressure value was not generated correctly!");

            BloodPressureValue = currentValue;
        }

        private void TestBatteryDataGenerated()
        {
            Simulator.Utils.DeviceDataGenerator generator = new Simulator.Utils.DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue = deviceData.BatteryPower.Value;

            Console.WriteLine($"[Battery] Init: {BatteryValue}, Current: {currentValue}");
            Assert.IsTrue(CheckBatteryDataGenerated(BatteryValue, currentValue,
                BatteryUpdateDelta, BatteryMinValue, BatteryMaxValue), "The battery value was not generated correctly!");

            BatteryValue = currentValue;
        }

        private bool CheckSensorsDataGenerated(double initValue, double newValue, double delta, double minValue, double maxValue)
        {
            if (Math.Abs(newValue - initValue) <= delta)
            {
                return newValue >= minValue && newValue <= maxValue;
            }
            return false;
        }

        private bool CheckBatteryDataGenerated(double initValue, double newValue, double delta, double minValue, double maxValue)
        {
            if (initValue - newValue <= delta)
            {
                return newValue >= minValue && newValue <= maxValue;
            }
            return false;
        }
    }
}
