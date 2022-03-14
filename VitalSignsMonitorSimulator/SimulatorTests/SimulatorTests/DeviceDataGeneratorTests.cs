using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simulator.Model;
using Simulator.Utils;
using System;
using System.Configuration;
using System.Globalization;

namespace SimulatorTests
{
    [TestClass]
    public class DataGeneratedTests
    {
        [TestMethod]
        public void TestTemperatureDataGenerated()
        {
            var appSettings = ConfigurationManager.AppSettings;

            double.TryParse(appSettings["TemperatureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureInitValue);
            double.TryParse(appSettings["TemperatureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureUpdateDelta);

            DeviceDataGenerator generator = new DeviceDataGenerator();
            DeviceData deviceData = generator.GetUpdatedDeviceData();
            double currentValue = deviceData.Temperature.Value;

            Console.WriteLine($"Keys: {appSettings.AllKeys}, Init: {temperatureInitValue}, Generated: {currentValue}");
            Assert.IsTrue(temperatureInitValue - currentValue <= temperatureUpdateDelta, "The temperature value generated correctly");
        }
    }
}
