using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Globalization;

namespace SimulatorTests.DeviceDataGenerator
{
    class DeviceThresholdDataGeneratorTest
    {
        private double TemperatureMinThresholdValue;
        private double TemperatureMaxThresholdValue;

        private double HeartFrequencyMinThresholdValue;
        private double HeartFrequencyMaxThresholdValue;

        private double BreathFrequencyMinThresholdValue;
        private double BreathFrequencyMaxThresholdValue;

        private double SaturationMinThresholdValue;
        private double SaturationMaxThresholdValue;

        private double BloodPressureMinThresholdValue;
        private double BloodPressureMaxThresholdValue;

        private double BatteryMinThresholdValue;
        private double BatteryMaxThresholdValue;

        [TestMethod]
        public void TestSensorsDataGenerated()
        {

            InitValue();

            TestTemperatureAlarm();
            TestHeartFrequencyAlarm();
            TestBreathFrequencyAlarm();
            TestSaturationAlarm();
            TestBloodPressureAlarm();
            TestBatteryAlarm();
        }
        private void InitValue()
        {
            var appSettings = ConfigurationManager.AppSettings;

            double.TryParse(appSettings["TemperatureMinAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMinThresholdValue);
            double.TryParse(appSettings["TemperatureMaxAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out TemperatureMaxThresholdValue);

            double.TryParse(appSettings["HeartFrequencyMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMinThresholdValue);
            double.TryParse(appSettings["HeartFrequencyMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out HeartFrequencyMaxThresholdValue);

            double.TryParse(appSettings["BreathFrequencyMinAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMinThresholdValue);
            double.TryParse(appSettings["BreathFrequencyMaxAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BreathFrequencyMaxThresholdValue);

            double.TryParse(appSettings["SaturationMinAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationMinThresholdValue);
            double.TryParse(appSettings["SaturationMaxAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out SaturationMaxThresholdValue);

            double.TryParse(appSettings["BloodPressureMinAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMinThresholdValue);
            double.TryParse(appSettings["BloodPressureMaxAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BloodPressureMaxThresholdValue);

            double.TryParse(appSettings["BatteryMinAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryMinThresholdValue);
            double.TryParse(appSettings["BatteryMaxAlarmThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out BatteryMaxThresholdValue);
        }

        private void TestTemperatureAlarm() {
            throw new NotImplementedException();
        }

        private void TestBatteryAlarm()
        {
            throw new NotImplementedException();
        }

        private void TestBloodPressureAlarm()
        {
            throw new NotImplementedException();
        }

        private void TestSaturationAlarm()
        {
            throw new NotImplementedException();
        }

        private void TestBreathFrequencyAlarm()
        {
            throw new NotImplementedException();
        }

        private void TestHeartFrequencyAlarm()
        {
            throw new NotImplementedException();
        }
    }
}
