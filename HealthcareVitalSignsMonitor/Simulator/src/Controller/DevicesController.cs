using Common.View;
using Newtonsoft.Json.Linq;
using Simulator.AzureApi;
using Simulator.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator.Controller
{
    public class DevicesController
    {
        private readonly DevicesForm _view;
        private readonly Action _onClose;
        private readonly Action<string> _onDeviceSelected;
        private readonly Action _onStartClick;
        private readonly Action _onStopClick;
        private readonly Action _onSettingsClick;
        private readonly ErrorForm _errorForm;
        private readonly SuccessForm _successForm;

        public DevicesController(Action onClose, Action<string> onDeviceSelected, Action onStartClick, Action onStopClick, Action onSettingsClick)
        {
            _view = new DevicesForm(this)
            {
                Text = "Control Panel",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._successForm = new SuccessForm()
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._onClose = onClose;
            this._onDeviceSelected = onDeviceSelected;
            this._onStartClick = onStartClick;
            this._onStopClick = onStopClick;
            this._onSettingsClick = onSettingsClick;
        }

        internal void Start()
        {
            Application.Run(_view);
        }

        internal void OnClose()
        {
            this._onClose();
        }

        internal void OnStartClick()
        {
            this._onStartClick();
        }

        internal void OnStopClick()
        {
            this._onStopClick();
        }

        internal async Task<List<JObject>> GetDevicesAsync()
        {
            List<JObject> devices = new List<JObject>();
            try
            {
                devices = await DeviceOperationsApi.GetDevices();

                string message = string.Empty;
                if (devices.Count != 0)
                {
                    message = "Device list loaded.";
                }
                else
                {
                    message = "No devices found.";
                }

                this._successForm.SetText(message);
                this._successForm.Show();
            }
            catch (Exception ex)
            {
                this._errorForm.SetText(ex.Message);
                this._errorForm.Show();
            }

            return devices;
        }

        internal void OnSettingsClick()
        {
            this._onSettingsClick();
        }

        internal void OnDeviceSelectedAsync(string deviceId)
        {
            this._onDeviceSelected(deviceId);
        }
    }
}
