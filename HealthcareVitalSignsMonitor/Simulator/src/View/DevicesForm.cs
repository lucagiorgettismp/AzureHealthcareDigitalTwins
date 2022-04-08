using Common.Utils;
using Simulator.Controller;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Simulator.src.View;

namespace Simulator.View
{
    public partial class DevicesForm : Form
    {
        private DevicesController _controller;
        private const string DEVICE_ID = "deviceId";

        public DevicesForm(DevicesController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this._controller.OnClose();
        }

        private void ControlPanelFormLoad(object sender, EventArgs e)
        {
            this.start_button.Enabled = false;
            this.stop_button.Enabled = false;
            this.settings_button.Enabled = false;
        }

        // Start button simulator 
        private void StartButtonClick(object sender, EventArgs e)
        {
            Log.Ok("Start simulation!");
            Console.WriteLine();

            this.start_button.Enabled = false;
            this.stop_button.Enabled = true;
            this.settings_button.Enabled = false;

            this._controller.OnStartClick();
        }

        // Stop button simulator
        private void StopButtonClick(object sender, EventArgs e)
        {
            Log.Ok("Stop simulation!");
            Console.WriteLine();

            this.start_button.Enabled = true;
            this.stop_button.Enabled = false;
            this.settings_button.Enabled = true;

            this._controller.OnStopClick();
        }

        private async void DevicesButtonClick(object sender, EventArgs e)
        {
            this.listbox_devices.Items.Clear();

            Log.Ok("Get all devices...");
            this.listbox_devices.Items.Add("Getting all devices");

            List<JObject> devices = await this._controller.GetDevicesAsync();

            this.listbox_devices.Items.Clear();

            foreach (var device in devices)
            {
                this.listbox_devices.Items.Add(device[DEVICE_ID]);
            }

        }

        private void OnDeviceSelected(object sender, EventArgs e)
        {
            var deviceId = this.listbox_devices.SelectedItem.ToString();
            if (deviceId != null)
            {
                this._controller.OnDeviceSelectedAsync(deviceId);

                Log.Ok("Click on: " + deviceId);

                this.start_button.Enabled = true;
                this.settings_button.Enabled = true;
            }
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            this._controller.OnSettingsClick();
        }
    }
}
