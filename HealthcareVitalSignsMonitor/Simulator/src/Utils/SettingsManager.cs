namespace Simulator.Utils
{
    using Common.Utils;
    using Model.Settings;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    internal class SettingsManager
    {
        private const string SETTINGS_PATH = "settings.json";

        public static bool SaveUserSettings(DeviceSettings settings)
        {
            try
            {
                SettingsFileModel settingsFile = null;
                if (!File.Exists(SETTINGS_PATH))
                {
                    var devices = new List<DeviceSettings> { settings };

                    settingsFile = new SettingsFileModel
                    {
                        Devices = devices
                    };

                    var jsonString = JsonConvert.SerializeObject(settingsFile);
                    using var streamWriter = File.CreateText(SETTINGS_PATH);
                    streamWriter.WriteLine(jsonString);
                    streamWriter.Flush();
                }
                else
                {
                    settingsFile = GetAllSettings();

                    if (settingsFile.Devices.Any(device => device.DeviceId == settings.DeviceId))
                    {
                        foreach (var deviceSetting in settingsFile.Devices.Where(device => device.DeviceId == settings.DeviceId))
                        {
                            deviceSetting.Temperature = settings.Temperature;
                            deviceSetting.BloodPressure = settings.BloodPressure;
                            deviceSetting.Saturation = settings.Saturation;
                            deviceSetting.BreathFrequency = settings.BreathFrequency;
                            deviceSetting.HeartFrequency = settings.HeartFrequency;
                            deviceSetting.BatteryPower = settings.BatteryPower;

                            break;
                        }
                    }
                    else
                    {
                        settingsFile.Devices.Add(settings);
                    }

                    using var streamWriter = new StreamWriter(SETTINGS_PATH);
                    var jsonString = JsonConvert.SerializeObject(settingsFile);
                    streamWriter.WriteLine(jsonString);
                    streamWriter.Flush();
                }
                return true;
            } catch (Exception e)
            {
                Log.Error(e.Message);
                return false;
            }
        }

        public static DeviceSettings ReadUserSettings(string deviceId)
        {
            if (File.Exists(SETTINGS_PATH))
            {
                var settings = GetAllSettings();
                var deviceSettings = settings.GetDeviceSettingsByDeviceId(deviceId);

                return deviceSettings ?? GetDefaultSettings();
            }

            return GetDefaultSettings();
        }

        public static TemperatureUnitOfMeasurement? GetTemperatureUnitOfMeasurementByValue(string value)
        {
            return value switch
            {
                "°C (Celsius)" => TemperatureUnitOfMeasurement.CELSIUS,
                "°F (Fahrenheit)" => TemperatureUnitOfMeasurement.FAHRENHEIT,
                "K (Kelvin)" => TemperatureUnitOfMeasurement.KELVIN,
                _ => null,
            };
        }

        public static TemperatureUnitOfMeasurement? GetTemperatureUnitOfMeasurementBySymbol(string symbol)
        {
            return symbol switch
            {
                "°C" => TemperatureUnitOfMeasurement.CELSIUS,
                "°F" => TemperatureUnitOfMeasurement.FAHRENHEIT,
                "K" => TemperatureUnitOfMeasurement.KELVIN,
                _ => null,
            };
        }

        private static SettingsFileModel GetAllSettings()
        {
            var streamReader = new StreamReader(SETTINGS_PATH);
            var jsonString = streamReader.ReadToEnd();

            streamReader.Close();

            return JsonConvert.DeserializeObject<SettingsFileModel>(jsonString);
        }

        private static DeviceSettings GetDefaultSettings()
        {
            var appSettings = ConfigurationManager.AppSettings;

            double.TryParse(appSettings["TemperatureMinValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMinValue);
            double.TryParse(appSettings["TemperatureMaxValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMaxValue);
            double.TryParse(appSettings["TemperatureMinAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMinAlert);
            double.TryParse(appSettings["TemperatureMaxAlertThresholdValue"], NumberStyles.Any, CultureInfo.CurrentCulture, out double temperatureMaxAlert);

            var temperature = new SensorSettingsMinMaxThreashold<double>
            {
                UnitOfMeasurement = appSettings["TemperatureUnitSymbol"],
                MinValue = temperatureMinValue,
                MaxValue = temperatureMaxValue,
                MinAlertThreashold = temperatureMinAlert,
                MaxAlertThreashold = temperatureMaxAlert,
            };

            var batteryPower = new SensorSettingsMinThreashold<int>
            {
                UnitOfMeasurement = appSettings["PercentageUnitSymbol"],
                MinValue = Convert.ToInt32(appSettings["BatteryMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BatteryMaxValue"]),
                MinAlertThreashold = Convert.ToInt32(appSettings["BatteryMinAlertThresholdValue"]),
            };

            var bloodPressure = new SensorSettingsMinMaxThreashold<int>
            {
                UnitOfMeasurement = appSettings["BloodPressureUnitSymbol"],
                MinValue = Convert.ToInt32(appSettings["BloodPressureMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BloodPressureMaxValue"]),
                MinAlertThreashold = Convert.ToInt32(appSettings["BloodPressureMinAlertThresholdValue"]),
                MaxAlertThreashold = Convert.ToInt32(appSettings["BloodPressureMaxAlertThresholdValue"]),
            };

            var breathFrequency = new SensorSettingsMinMaxThreashold<int>
            {
                UnitOfMeasurement = appSettings["BreathFrequencyUnitSymbol"],
                MinValue = Convert.ToInt32(appSettings["BreathFrequencyMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["BreathFrequencyMaxValue"]),
                MinAlertThreashold = Convert.ToInt32(appSettings["BreathFrequencyMinAlertThresholdValue"]),
                MaxAlertThreashold = Convert.ToInt32(appSettings["BreathFrequencyMaxAlertThresholdValue"]),
            };

            var heartFrequency = new SensorSettingsMinMaxThreashold<int>
            {
                UnitOfMeasurement = appSettings["HeartFrequencyUnitSymbol"],
                MinValue = Convert.ToInt32(appSettings["HeartFrequencyMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["HeartFrequencyMaxValue"]),
                MinAlertThreashold = Convert.ToInt32(appSettings["HeartFrequencyMinAlertThresholdValue"]),
                MaxAlertThreashold = Convert.ToInt32(appSettings["HeartFrequencyMaxAlertThresholdValue"]),
            };

            var saturation = new SensorSettingsMinThreashold<int>
            {
                UnitOfMeasurement = appSettings["PercentageUnitSymbol"],
                MinValue = Convert.ToInt32(appSettings["SaturationMinValue"]),
                MaxValue = Convert.ToInt32(appSettings["SaturationMaxValue"]),
                MinAlertThreashold = Convert.ToInt32(appSettings["SaturationMinAlertThresholdValue"]),
            };

            return new DeviceSettings
            {
                Temperature = temperature,
                BatteryPower = batteryPower,
                BloodPressure = bloodPressure,
                BreathFrequency = breathFrequency,
                HeartFrequency = heartFrequency,
                Saturation = saturation
            };
        }
    }
}
