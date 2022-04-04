namespace Simulator.View
{
    using Common.Utils;
    using Controller;
    using Newtonsoft.Json.Linq;
    using Simulator.AzureApi;
    using Simulator;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Common;
    using Common.View;
    using Simulator.src.View;

    public partial class ControlPanelForm : Form
    {
        private Device deviceHub = null;
        private CancellationTokenSource tokenSource = null;

        private SimulationForm simulationForm = null;
        private SettingsForm settingsForm = null;

        private Button startButton;
        private Button stopButton;

        private const string ID_START_BUTTON = "start_button";
        private const string ID_STOP_BUTTON = "stop_button";
        private const string DEVICE_ID = "deviceId";

        private SuccessForm successForm;
        private ErrorForm errorForm;

        public ControlPanelForm()
        {
            InitializeComponent();

            this.errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            this.successForm = new SuccessForm()
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            this.settingsForm = new SettingsForm();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.simulationForm != null)
            {
                this.simulationForm.Close();
            }

            if(this.tokenSource != null)
            {
                this.tokenSource.Cancel();
            }

            base.OnFormClosing(e);
        }

        private void ControlPanelFormLoad(object sender, EventArgs e)
        {
            this.startButton = this.Controls.Find(ID_START_BUTTON, true).FirstOrDefault() as Button;
            this.startButton.Enabled = false;

            this.stopButton = this.Controls.Find(ID_STOP_BUTTON, true).FirstOrDefault() as Button;
            this.stopButton.Enabled = false;

            this.settings_button.Enabled = false;
        }

        // Start button simulator 
        private async void StartButtonClick(object sender, EventArgs e)
        {
            if (this.deviceHub != null)
            {
                try
                {
                    Log.Ok("Start simulation!");
                    Console.WriteLine();

                    this.stopButton.Enabled = true;
                    this.startButton.Enabled = false;

                    this.simulationForm = new SimulationForm();
                    this.simulationForm.Text = "Simulation";
                    this.simulationForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    this.simulationForm.Show();

                    this.tokenSource = new CancellationTokenSource();
                    await this.deviceHub.SendMessageToIoTHub(this.simulationForm, this.tokenSource.Token);
                }catch(Exception ex)
                {
                    this.errorForm.SetText(ex.Message);
                    this.errorForm.Show();
                }
            }
        }

        // Stop button simulator
        private void StopButtonClick(object sender, EventArgs e)
        {
            Log.Ok("Stop simulation!");
            Console.WriteLine();

            this.stopButton.Enabled = false;
            this.startButton.Enabled = true;

            this.simulationForm.Close();
            this.tokenSource.Cancel();
        }

        private async void DevicesButtonClick(object sender, EventArgs e)
        {
            this.listbox_devices.Items.Clear();

            try
            {
                Log.Ok("Get all devices...");
                List<JObject> devices = await DeviceOperationsApi.GetDevices();
                foreach (var device in devices)
                {
                    this.listbox_devices.Items.Add(device[DEVICE_ID]);
                }

                string message;
                if(this.listbox_devices.Items.Count != 0)
                {
                    message = "Device list loaded.";
                }
                else
                {
                    message = "No devices found.";
                }
                this.successForm.SetText(message);
                this.successForm.Show();
            }
            catch(Exception ex)
            {
                this.errorForm.SetText(ex.Message);
                this.errorForm.Show();
            }
        }

        private async void SelectedIndexDevices(object sender, EventArgs e)
        {
            try
            {
                if (this.listbox_devices.SelectedItem != null)
                {
                    var deviceId = this.listbox_devices.SelectedItem.ToString();

                    Log.Ok("Click on: " + deviceId);

                    string connection = await DeviceOperationsApi.GetConnectionString(deviceId);
                    this.deviceHub = new Device(connection, deviceId);

                    settingsForm.SetDeviceId(deviceId);

                    this.startButton.Enabled = true;
                    this.settings_button.Enabled = true;
                }
            }catch(Exception ex)
            {
                Log.Error(ex.Message);
                this.errorForm.SetText(ex.Message);
                this.errorForm.Show();
            }
        }

        private void ButtonTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            settingsForm.Show();
        }
    }
}
