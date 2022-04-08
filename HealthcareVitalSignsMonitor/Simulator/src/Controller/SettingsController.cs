using Common.View;
using Simulator.Model.Settings;
using Simulator.src;
using Simulator.src.View;
using System.Windows.Forms;

namespace Simulator.Controller
{
    public class SettingsController
    {
        private string _deviceId;
        private SettingsForm _view;
        private SuccessForm _successForm;
        private ErrorForm _errorForm;

        public SettingsController(string deviceId)
        {
            this._deviceId = deviceId;
            this._view = new SettingsForm(this)
            {
                Text = "Simulation",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._successForm = new SuccessForm(onCloseAction: () => { this.Close(); })
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };
        }

        internal void Close()
        {
            this._view.Hide();
        }

        internal void Start()
        {
            var settings = SettingsManager.ReadUserSettings(_deviceId);
            this._view.InitFields(settings);
            this._view.Show();
        }

        internal void SaveSettings(DeviceSettings deviceSettings)
        {
            deviceSettings.DeviceId = _deviceId;

            if (SettingsManager.SaveUserSettings(deviceSettings))
            {
                this._successForm.SetText("Settings saved");
                this._successForm.Show();
            }
            else
            {
                this._errorForm.SetText("Error in saving settings");
                this._errorForm.Show();
            }
        }
    }
}