namespace Simulator.Controller
{
    using Common.View;
    using Model.Settings;
    using System.Windows.Forms;
    using Utils;
    using View;

    public class SettingsController
    {
        private readonly string _deviceId;
        private readonly SettingsForm _view;
        private readonly SuccessForm _successForm;
        private readonly ErrorForm _errorForm;

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