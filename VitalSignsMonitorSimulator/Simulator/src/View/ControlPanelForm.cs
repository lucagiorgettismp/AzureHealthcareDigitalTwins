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
    using Microsoft.Azure.Devices.Client;
    using Simulator.src.AzureApi;
    using Azure.DigitalTwins.Core;
    using Common.AzureApi;

    public partial class ControlPanelForm : Form
    {
        private Device deviceHub = null;
        private CancellationTokenSource tokenSource;

        private SimulationForm simulationForm;

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

            this.ControlBox = false;
        }

        private void ControlPanelFormLoad(object sender, EventArgs e)
        {
            this.startButton = this.Controls.Find(ID_START_BUTTON, true).FirstOrDefault() as Button;
            this.startButton.Enabled = false;

            this.stopButton = this.Controls.Find(ID_STOP_BUTTON, true).FirstOrDefault() as Button;
            this.stopButton.Enabled = false;
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
                    message = "Devices found!";
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
                    string itemName = this.listbox_devices.SelectedItem.ToString();
                    Log.Ok("Click on: " + itemName);

                    string connection = await DeviceOperationsApi.GetConnectionString(this.listbox_devices.SelectedItem.ToString());
                    this.deviceHub = new Device(connection);

                    DigitalTwinsClient twinClient = AuthenticationApi.GetClient();
                    TwinOperationApi.GetPatientTwin(twinClient, itemName);

                    this.deviceHub = new Device(itemName, deviceClient);
                    this.startButton.Enabled = true;
                }
            }catch(Exception ex)
            {
                Log.Error(ex.Message);
                this.errorForm.SetText(ex.Message);
                this.errorForm.Show();
            }
        }
    }
}
