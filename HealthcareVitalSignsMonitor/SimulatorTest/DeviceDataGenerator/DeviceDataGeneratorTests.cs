namespace SimulatorTest.DeviceDataGenerator
{
    using Common.Utils;
    using Common.Utils.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Simulator.Model;
    using System;
    using System.Configuration;
    using System.Globalization;

    [TestClass]
    public class DataGeneratedTests
    {
        private double _temperatureValue;
        private double _temperatureMinValue;
        private double _temperatureMaxValue;
        private double _temperatureUpdateDelta;
        private double _temperatureMinThresholdValue;
        private double _temperatureMaxThresholdValue;

        private double _heartFrequencyValue;
        private double _heartFrequencyMinValue;
        private double _heartFrequencyMaxValue;
        private double _heartFrequencyUpdateDelta;
        private double _heartFrequencyMinThresholdValue;
        private double _heartFrequencyMaxThresholdValue;

        private double _breathFrequencyValue;
        private double _breathFrequencyMinValue;
        private double _breathFrequencyMaxValue;
        private double _breathFrequencyUpdateDelta;
        private double _breathFrequencyMinThresholdValue;
        private double _breathFrequencyMaxThresholdValue;

        private double _saturationValue;
        private double _saturationMinValue;
        private double _saturationMaxValue;
        private double _saturationUpdateDelta;
        private double _saturationMinThresholdValue;

        private double _bloodPressureValue;
        private double _bloodPressureMinValue;
        private double _bloodPressureMaxValue;
        private double _bloodPressureUpdateDelta;
        private double _bloodPressureMinThresholdValue;
        private double _bloodPressureMaxThresholdValue;

        private double _batteryValue;
        private double _batteryMinValue;
        private double _batteryMaxValue;
        private double _batteryUpdateDelta;
        private double _batteryMinThresholdValue;

        private Simulator.Utils.DeviceDataGenerator _generator;

        private const string DEVICE_ID = "PGNLNZ97M18G479M";

        [TestMethod]
        public void TestSensorsDataGenerated() {
            InitValue();

            for (int i = 0; i <= 9; i++)
            {
                DeviceData deviceData = _generator.GetUpdatedDeviceData();

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
            try
            {
                _generator = new Simulator.Utils.DeviceDataGenerator(DEVICE_ID);

                var appSettings = ConfigurationManager.AppSettings;

                // Init value sensor
                double.TryParse(appSettings["TemperatureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _temperatureValue);
                double.TryParse(appSettings["HeartFrequencyInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _heartFrequencyValue);
                double.TryParse(appSettings["BreathFrequencyInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _breathFrequencyValue);
                double.TryParse(appSettings["SaturationInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _saturationValue);
                double.TryParse(appSettings["BloodPressureInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _bloodPressureValue);
                double.TryParse(appSettings["BatteryInitValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _batteryValue);

                // Setting temperature
                double.TryParse(appSettings["TemperatureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _temperatureUpdateDelta);
                double.TryParse(appSettings["TemperatureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _temperatureMinValue);
                double.TryParse(appSettings["TemperatureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _temperatureMaxValue);
                double.TryParse(appSettings["TemperatureMinAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _temperatureMinThresholdValue);
                double.TryParse(appSettings["TemperatureMaxAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _temperatureMaxThresholdValue);

                // Setting _heart Frequency
                double.TryParse(appSettings["HeartFrequencyUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _heartFrequencyUpdateDelta);
                double.TryParse(appSettings["HeartFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _heartFrequencyMinValue);
                double.TryParse(appSettings["HeartFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _heartFrequencyMaxValue);
                double.TryParse(appSettings["HeartFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _heartFrequencyMinThresholdValue);
                double.TryParse(appSettings["HeartFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _heartFrequencyMaxThresholdValue);

                // Setting Breath Frequency
                double.TryParse(appSettings["BreathFrequencyUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _breathFrequencyUpdateDelta);
                double.TryParse(appSettings["BreathFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _breathFrequencyMinValue);
                double.TryParse(appSettings["BreathFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _breathFrequencyMaxValue);
                double.TryParse(appSettings["BreathFrequencyMinAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _breathFrequencyMinThresholdValue);
                double.TryParse(appSettings["BreathFrequencyMaxAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _breathFrequencyMaxThresholdValue);

                // Setting Saturation
                double.TryParse(appSettings["SaturationUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _saturationUpdateDelta);
                double.TryParse(appSettings["SaturationMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _saturationMinValue);
                double.TryParse(appSettings["SaturationMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _saturationMaxValue);
                double.TryParse(appSettings["SaturationMinAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _saturationMinThresholdValue);

                // Setting Blood Pressure
                double.TryParse(appSettings["BloodPressureUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _bloodPressureUpdateDelta);
                double.TryParse(appSettings["BloodPressureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _bloodPressureMinValue);
                double.TryParse(appSettings["BloodPressureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _bloodPressureMaxValue);
                double.TryParse(appSettings["BloodPressureMinAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _bloodPressureMinThresholdValue);
                double.TryParse(appSettings["BloodPressureMaxAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _bloodPressureMaxThresholdValue);

                // Setting Battery
                double.TryParse(appSettings["BatteryUpdateDelta"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _batteryUpdateDelta);
                double.TryParse(appSettings["BatteryMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _batteryMinValue);
                double.TryParse(appSettings["BatteryMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture,
                    out _batteryMaxValue);
                double.TryParse(appSettings["BatteryMinAlertThresholdValue"], NumberStyles.Any,
                    CultureInfo.CurrentCulture, out _batteryMinThresholdValue);
            }
            catch (Exception e) when (e is InvalidPropertyTypeException || e is ConfigurationErrorsException)
            {
                Log.Error(e.Message);
            }
        }

        private void TestTemperatureDataGenerated(DeviceDataPropertyMinMaxThreshold<double> temperature)
        {
            double currentValue = temperature.Value;

            Console.WriteLine($"[Temperature] Init: {_temperatureValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(_temperatureValue, currentValue,
                _temperatureUpdateDelta, _temperatureMinValue, _temperatureMaxValue), "The temperature value was not generated correctly!");

            _temperatureValue = currentValue;

            var inAlert = temperature.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(_temperatureValue, _temperatureMinThresholdValue, _temperatureMaxThresholdValue), inAlert);
        }

        private void TestHeartFrequencyDataGenerated(DeviceDataPropertyMinMaxThreshold<int> heartFrequency)
        {
            double currentValue = heartFrequency.Value;

            Console.WriteLine($"[Heart Frequency] Init: {_heartFrequencyValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(_heartFrequencyValue, currentValue,
                _heartFrequencyUpdateDelta, _heartFrequencyMinValue, _heartFrequencyMaxValue), "The heart frequency value was not generated correctly!");

            _heartFrequencyValue = currentValue;

            var inAlert = heartFrequency.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(_heartFrequencyValue, _heartFrequencyMinThresholdValue, _heartFrequencyMaxThresholdValue), inAlert);
        }

        private void TestBreathFrequencyDataGenerated(DeviceDataPropertyMinMaxThreshold<int> breathFrequency)
        { 
            double currentValue = breathFrequency.Value;

            Console.WriteLine($"[Breath Frequency] Init: {_breathFrequencyValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(_breathFrequencyValue, currentValue,
                _breathFrequencyUpdateDelta, _breathFrequencyMinValue, _breathFrequencyMaxValue), "The breath frequency value was not generated correctly!");

            _breathFrequencyValue = currentValue;

            bool inAlert = breathFrequency.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(_breathFrequencyValue, _breathFrequencyMinThresholdValue, _breathFrequencyMaxThresholdValue), inAlert);
        }

        private void TestSaturationDataGenerated(DeviceDataPropertyMinThreshold<int> saturation)
        {
            double currentValue = saturation.Value;

            Console.WriteLine($"[Saturation] Init: {_saturationValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(_saturationValue, currentValue,
                _saturationUpdateDelta, _saturationMinValue, _saturationMaxValue), "The saturation value was not generated correctly!");

            _saturationValue = currentValue;

            bool inAlert = saturation.InAlert;
            Assert.AreEqual(CheckMinAlertSensors(_saturationValue, _saturationMinThresholdValue), inAlert);
        }

        private void TestBloodPressureDataGenerated(DeviceDataPropertyMinMaxThreshold<int> bloodPressure)
        {           
            double currentValue = bloodPressure.Value;

            Console.WriteLine($"[Blood Pressure] Init: {_bloodPressureValue}, Current: {currentValue}");
            Assert.IsTrue(CheckSensorsDataGenerated(_bloodPressureValue, currentValue,
                _bloodPressureUpdateDelta, _bloodPressureMinValue, _bloodPressureMaxValue), "The blood Pressure value was not generated correctly!");

            _bloodPressureValue = currentValue;

            bool inAlert = bloodPressure.InAlert;
            Assert.AreEqual(CheckMinMaxAlertSensors(_bloodPressureValue, _bloodPressureMinThresholdValue, _bloodPressureMaxThresholdValue), inAlert);
        }

        private void TestBatteryPowerDataGenerated(DeviceDataPropertyMinThreshold<int> batteryPower)
        {
            double currentValue = batteryPower.Value;

            Console.WriteLine($"[Battery] Init: {_batteryValue}, Current: {currentValue}");
            Assert.IsTrue(CheckBatteryDataGenerated(_batteryValue, currentValue,
                _batteryUpdateDelta, _batteryMinValue, _batteryMaxValue), "The battery value was not generated correctly!");

            _batteryValue = currentValue;

            bool inAlert = batteryPower.InAlert;
            Assert.AreEqual(CheckMinAlertSensors(_batteryValue, _batteryMinThresholdValue), inAlert);
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
