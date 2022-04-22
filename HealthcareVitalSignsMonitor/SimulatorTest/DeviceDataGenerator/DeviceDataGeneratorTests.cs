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
        private double TemperatureMinThresholdValue;
        private double TemperatureMaxThresholdValue;

        private double HeartFrequencyValue;
        private double HeartFrequencyMinValue;
        private double HeartFrequencyMaxValue;
        private double HeartFrequencyUpdateDelta;
        private double HeartFrequencyMinThresholdValue;
        private double HeartFrequencyMaxThresholdValue;

        private double BreathFrequencyValue;
        private double BreathFrequencyMinValue;
        private double BreathFrequencyMaxValue;
        private double BreathFrequencyUpdateDelta;
        private double BreathFrequencyMinThresholdValue;
        private double BreathFrequencyMaxThresholdValue;

        private double SaturationValue;
        private double SaturationMinValue;
        private double SaturationMaxValue;
        private double SaturationUpdateDelta;
        private double SaturationMinThresholdValue;

        private double BloodPressureValue;
        private double BloodPressureMinValue;
        private double BloodPressureMaxValue;
        private double BloodPressureUpdateDelta;
        private double BloodPressureMinThresholdValue;
        private double BloodPressureMaxThresholdValue;

        private double BatteryValue;
        private double BatteryMinValue;
        private double BatteryMaxValue;
        private double BatteryUpdateDelta;
        private double BatteryMinThresholdValue;

        private Simulator.Utils.DeviceDataGenerator Generator;

        private const string DEVICE_ID = "PGNLNZ97M18G479M";

        [TestMethod]
        public void TestSensorsDataGenerated() {
            InitValue();

            for (int i = 0; i <= 9; i++)
            {
                DeviceData deviceData = Generator.GetUpdatedDeviceData();

                TestTemperatureDataGenerated(deviceData.Temperature);
                TestHeartFrequencyDataGenerated(deviceData.HeartFrequency);
                TestBreathFrequencyDataGenerated(deviceData.BreathFrequency);
                TestSaturationDataGenerated(deviceData.Saturation);
                TestBloodPressureDataGenerated(deviceData.BloodPressure);
                TestBatteryPowerDataGenerated(deviceData.BatteryPower);
                Console.WriteLine("\n\n");
            }
        }

        private void InitValue()
        {
            Generator = new Simulator.Utils.DeviceDataGenerator(DEVICE_ID);

            var appSettings = ConfigurationManager.AppSettings;

            // Init value sensor
            double.TryParse(appSettings["TemperatureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureValue);
            double.TryParse(appSettings["HeartFrequencyInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyValue);
            double.TryParse(appSettings["BreathFrequencyInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyValue);
            double.TryParse(appSettings["SaturationInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationValue);
            double.TryParse(appSettings["BloodPressureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureValue); 
            double.TryParse(appSettings["BatteryInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryValue);

            // Setting temperature
            double.TryParse(appSettings["TemperatureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureUpdateDelta);
            double.TryParse(appSettings["TemperatureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMinValue);
            double.TryParse(appSettings["TemperatureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMaxValue);
            double.TryParse(appSettings["TemperatureMinAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMinThresholdValue);
            double.TryParse(appSettings["TemperatureMaxAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMaxThresholdValue);

            // Setting Heart Frequency
            double.TryParse(appSettings["HeartFrequencyUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyUpdateDelta);
            double.TryParse(appSettings["HeartFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMinValue);
            double.TryParse(appSettings["HeartFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMaxValue);
            double.TryParse(appSettings["HeartFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMinThresholdValue);
            double.TryParse(appSettings["HeartFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMaxThresholdValue);

            // Setting Breath Frequency
            double.TryParse(appSettings["BreathFrequencyUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyUpdateDelta);
            double.TryParse(appSettings["BreathFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMinValue);
            double.TryParse(appSettings["BreathFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMaxValue);
            double.TryParse(appSettings["BreathFrequencyMinAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMinThresholdValue);
            double.TryParse(appSettings["BreathFrequencyMaxAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMaxThresholdValue);

            // Setting Saturation
            double.TryParse(appSettings["SaturationUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationUpdateDelta);
            double.TryParse(appSettings["SaturationMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationMinValue);
            double.TryParse(appSettings["SaturationMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationMaxValue);
            double.TryParse(appSettings["SaturationMinAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationMinThresholdValue);

            // Setting Blood Pressure
            double.TryParse(appSettings["BloodPressureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureUpdateDelta);
            double.TryParse(appSettings["BloodPressureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMinValue);
            double.TryParse(appSettings["BloodPressureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMaxValue);
            double.TryParse(appSettings["BloodPressureMinAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMinThresholdValue);
            double.TryParse(appSettings["BloodPressureMaxAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMaxThresholdValue);

            // Setting Battery
            double.TryParse(appSettings["BatteryUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryUpdateDelta);
            double.TryParse(appSettings["BatteryMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryMinValue);
            double.TryParse(appSettings["BatteryMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryMaxValue);
            double.TryParse(appSettings["BatteryMinAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryMinThresholdValue);
        }

        private void TestTemperatureDataGenerated(DeviceDataPropertyMinMaxThreshold<double> temperature)
        {
            double currentValue = temperature.Value;

            Console.WriteLine($"[Temperature] Init: {TemperatureValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(TemperatureValue, currentValue,
                TemperatureUpdateDelta, TemperatureMinValue, TemperatureMaxValue), "The temperature value was not generated correctly!");

            TemperatureValue = currentValue;

            var inAlert = temperature.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(TemperatureValue, TemperatureMinThresholdValue, TemperatureMaxThresholdValue), inAlert);
        }

        private void TestHeartFrequencyDataGenerated(DeviceDataPropertyMinMaxThreshold<int> heartFrequency)
        {
            double currentValue = heartFrequency.Value;

            Console.WriteLine($"[Heart Frequency] Init: {HeartFrequencyValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(HeartFrequencyValue, currentValue,
                HeartFrequencyUpdateDelta, HeartFrequencyMinValue, HeartFrequencyMaxValue), "The heart frequency value was not generated correctly!");

            HeartFrequencyValue = currentValue;

            var inAlert = heartFrequency.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(HeartFrequencyValue, HeartFrequencyMinThresholdValue, HeartFrequencyMaxThresholdValue), inAlert);
        }

        private void TestBreathFrequencyDataGenerated(DeviceDataPropertyMinMaxThreshold<int> breathFrequency)
        { 
            double currentValue = breathFrequency.Value;

            Console.WriteLine($"[Breath Frequency] Init: {BreathFrequencyValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(BreathFrequencyValue, currentValue,
                BreathFrequencyUpdateDelta, BreathFrequencyMinValue, BreathFrequencyMaxValue), "The breath frequency value was not generated correctly!");

            BreathFrequencyValue = currentValue;

            bool inAlert = breathFrequency.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(BreathFrequencyValue, BreathFrequencyMinThresholdValue, BreathFrequencyMaxThresholdValue), inAlert);
        }

        private void TestSaturationDataGenerated(DeviceDataPropertyMinThreshold<int> saturation)
        {
            double currentValue = saturation.Value;

            Console.WriteLine($"[Saturation] Init: {SaturationValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(SaturationValue, currentValue,
                SaturationUpdateDelta, SaturationMinValue, SaturationMaxValue), "The saturation value was not generated correctly!");

            SaturationValue = currentValue;

            bool inAlert = saturation.InAlert;
            Assert.AreEqual(CheckMinAlertSensors(SaturationValue, SaturationMinThresholdValue), inAlert);
        }

        private void TestBloodPressureDataGenerated(DeviceDataPropertyMinMaxThreshold<int> bloodPressure)
        {           
            double currentValue = bloodPressure.Value;

            Console.WriteLine($"[Blood Pressure] Init: {BloodPressureValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(BloodPressureValue, currentValue,
                BloodPressureUpdateDelta, BloodPressureMinValue, BloodPressureMaxValue), "The blood Pressure value was not generated correctly!");

            BloodPressureValue = currentValue;

            bool inAlert = bloodPressure.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(BloodPressureValue, BloodPressureMinThresholdValue, BloodPressureMaxThresholdValue), inAlert);
        }

        private void TestBatteryPowerDataGenerated(DeviceDataPropertyMinThreshold<int> batteryPower)
        {
            double currentValue = batteryPower.Value;

            Console.WriteLine($"[Battery] Init: {BatteryValue}, Current: {currentValue}");
            Assert.IsTrue(CheckBatteryDataGenerated(BatteryValue, currentValue,
                BatteryUpdateDelta, BatteryMinValue, BatteryMaxValue), "The battery value was not generated correctly!");

            BatteryValue = currentValue;

            bool inAlert = batteryPower.InAlert;
            Assert.AreEqual(CheckMinAlertSensors(BatteryValue, BatteryMinThresholdValue), inAlert);
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

        private bool CheckMinMaxAlertSensors(double value, double minThreshold, double maxThreshold)
        {
            return minThreshold >= value || value >= maxThreshold;
        }

        private bool CheckMinAlertSensors(double value, double minThreshold)
        {
            return minThreshold >= value;
        }
    }
}
