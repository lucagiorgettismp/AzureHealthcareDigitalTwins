﻿using Common;
using Common.View;
using Simulator.Model.Settings;
using Simulator.src.Model.Settings;
using System;
using System.Windows.Forms;

namespace Simulator.src.View
{
    public partial class SettingsForm : Form
    {
        private SuccessForm successForm;
        private ErrorForm errorForm;
        private string deviceId;

        public SettingsForm()
        {
            InitializeComponent();

            this.successForm = new SuccessForm(onCloseAction: () => { this.Hide(); })
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            this.errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
        }

        public void SetDeviceId(string deviceId)
        {
            this.deviceId = deviceId;
            InitFields(deviceId);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
        }


        private void InitFields(string deviceId)
        {
            var settings = SettingsManager.ReadUserSettings(deviceId);

            if (settings != null)
            {
                this.battery_alert_min.Text = settings.BatteryPower.MinAlertThreashold.ToString();
                this.blood_press_alert_max.Text = settings.BloodPressure.MaxAlertThreashold.ToString();
                this.blood_press_alert_min.Text = settings.BloodPressure.MinAlertThreashold.ToString();
                this.blood_press_max.Text = settings.BloodPressure.MaxValue.ToString();
                this.blood_press_min.Text = settings.BloodPressure.MinValue.ToString();
                this.blood_press_uom.Text = settings.BloodPressure.UnitOfMeasurement;
                this.breath_freq_alert_max.Text = settings.BreathFrequency.MaxAlertThreashold.ToString();
                this.breath_freq_alert_min.Text = settings.BreathFrequency.MinAlertThreashold.ToString();
                this.breath_freq_max.Text = settings.BreathFrequency.MaxValue.ToString();
                this.breath_freq_min.Text = settings.BreathFrequency.MinValue.ToString();
                this.breath_freq_uom.Text = settings.BreathFrequency.UnitOfMeasurement;
                this.heart_freq_alert_max.Text = settings.HeartFrequency.MaxAlertThreashold.ToString();
                this.heart_freq_alert_min.Text = settings.HeartFrequency.MinAlertThreashold.ToString();
                this.heart_freq_max.Text = settings.HeartFrequency.MaxValue.ToString();
                this.heart_freq_min.Text = settings.HeartFrequency.MinValue.ToString();
                this.heart_freq_uom.Text = settings.HeartFrequency.UnitOfMeasurement;
                this.saturation_alert_min.Text = settings.Saturation.MinAlertThreashold.ToString();
                this.temperature_alert_max.Text = settings.Temperature.MaxAlertThreashold.ToString();
                this.temperature_alert_min.Text = settings.Temperature.MinAlertThreashold.ToString();
                this.temperature_max.Text = settings.Temperature.MaxValue.ToString();
                this.temperature_min.Text = settings.Temperature.MinValue.ToString();
                this.temperature_uom.Items.AddRange(this.GetTemperatureValues());
                this.temperature_uom.SelectedIndex = temperature_uom.FindStringExact(SettingsManager.GetTemperatureUnitOfMeasurementBySymbol(settings.Temperature.UnitOfMeasurement)?.Label());
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (SettingsManager.SaveUserSettings(new DeviceSettings
            {
                DeviceId = this.deviceId,
                Temperature = new SensorSettingsMinMaxThreashold<double>
                {
                    MinValue = GetDouble(this.temperature_min.Text),
                    MaxValue = GetDouble(this.temperature_max.Text),
                    MinAlertThreashold = GetDouble(this.temperature_alert_min.Text),
                    MaxAlertThreashold = GetDouble(this.temperature_alert_max.Text),
                    UnitOfMeasurement = SettingsManager.GetTemperatureUnitOfMeasurementByValue(this.temperature_uom.SelectedItem.ToString())?.Symbol()
                },
                BloodPressure = new SensorSettingsMinMaxThreashold<int>
                {
                    MinValue = Convert.ToInt32(this.blood_press_min.Text),
                    MaxValue = Convert.ToInt32(this.blood_press_max.Text),
                    MinAlertThreashold = Convert.ToInt32(this.blood_press_alert_min.Text),
                    MaxAlertThreashold = Convert.ToInt32(this.blood_press_alert_max.Text),
                    UnitOfMeasurement = this.blood_press_uom.Text
                },
                Saturation = new SensorSettingsMinThreashold<int>
                {
                    MinValue = 0,
                    MaxValue = 100,
                    MinAlertThreashold = Convert.ToInt32(this.saturation_alert_min.Text),
                    UnitOfMeasurement = "%"
                },
                BreathFrequency = new SensorSettingsMinMaxThreashold<int>
                {
                    MinValue = Convert.ToInt32(this.breath_freq_min.Text),
                    MaxValue = Convert.ToInt32(this.breath_freq_max.Text),
                    MinAlertThreashold = Convert.ToInt32(this.breath_freq_alert_min.Text),
                    MaxAlertThreashold = Convert.ToInt32(this.breath_freq_alert_max.Text),
                    UnitOfMeasurement = this.breath_freq_uom.Text
                },
                HeartFrequency = new SensorSettingsMinMaxThreashold<int>
                {
                    MinValue = Convert.ToInt32(this.heart_freq_min.Text),
                    MaxValue = Convert.ToInt32(this.heart_freq_max.Text),
                    MinAlertThreashold = Convert.ToInt32(this.heart_freq_alert_min.Text),
                    MaxAlertThreashold = Convert.ToInt32(this.heart_freq_alert_max.Text),
                    UnitOfMeasurement = this.heart_freq_uom.Text
                },
                BatteryPower = new SensorSettingsMinThreashold<int>
                {
                    MinValue = 0,
                    MaxValue = 100,
                    MinAlertThreashold = Convert.ToInt32(this.battery_alert_min.Text),
                    UnitOfMeasurement = "%"
                }
            }))
            {
                this.successForm.SetText("Settings saved");
                this.successForm.Show();
            } else
            {
                this.errorForm.SetText("Error in saving settings");
                this.errorForm.Show();
            }
        }

        private double GetDouble(string text)
        {
            return Convert.ToDouble(text.Replace(".", ","));
        }
    }
}
