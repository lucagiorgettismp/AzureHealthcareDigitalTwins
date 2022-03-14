using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simulator.Model;
using System;
using System.Configuration;
using System.Globalization;
using System.Reflection;

namespace SimulatorTests
{
    [TestClass]
    public class DataGeneratedTests
    {
        private bool CheckConditionsDataGenerated(double initValue, double newValue, double delta, double minValue, double maxValue)
        { 
            if (Math.Abs(newValue - initValue) <= delta)
            {
                return newValue >= minValue && newValue <= maxValue;
            }
            return false;
        }

        [TestMethod]
        public void TestTemperatureDataGenerated()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var configLocation = Assembly.GetEntryAssembly().Location;
            Console.WriteLine($"Location: {configLocation}");

            double.TryParse(appSettings["TemperatureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureInitValue);
            double.TryParse(appSettings["TemperatureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureUpdateDelta);
            double.TryParse(appSettings["TemperatureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMinValue);
            double.TryParse(appSettings["TemperatureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMaxValue);

            Simulator.Utils.DeviceDataGenerator generator = new Simulator.Utils.DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue =  deviceData.Temperature.Value;

            Console.WriteLine($"Keys: {appSettings.AllKeys}, Init: {temperatureInitValue}, Generated: {currentValue}");
            Assert.IsTrue(CheckConditionsDataGenerated(temperatureInitValue, currentValue, 
                temperatureUpdateDelta, temperatureMinValue, temperatureMaxValue), "The temperature value generated correctly");
        }
    }
}
