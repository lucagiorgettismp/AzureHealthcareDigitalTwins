namespace Simulator.View
{
    using Common;
    using Common.Enums;
    using Common.Utils;
    using Controller;
    using Newtonsoft.Json.Linq;
    using Simulator.AzureApi;
    using Simulator.src;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public partial class ControlPanelForm : Form
    {
        private Device deviceHub = null;
        private CancellationTokenSource tokenSource;

        private SimulationForm simulationForm;

        private Button startButton;
        private Button stopButton;

        private const string ID_START_BUTTON = "start_button";
        private const string ID_STOP_BUTTON = "stop_button";

        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void ControlPanelForm_Load(object sender, EventArgs e)
        {
            this.startButton = this.Controls.Find(ID_START_BUTTON, true).FirstOrDefault() as Button;
            this.startButton.Enabled = false;

            this.stopButton = this.Controls.Find(ID_STOP_BUTTON, true).FirstOrDefault() as Button;
            this.stopButton.Enabled = false;
        }

        // Start button simulator 
        private async void start_button_click(object sender, EventArgs e)
        {
            if (this.deviceHub != null)
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
                await this.deviceHub.SendMessageToIoTHub(this.simulationForm, this.tokenSource.Token, CrudMode.Update);
            }
        }

        // Stop button simulator
        private void stop_button_click(object sender, EventArgs e)
        {
            Log.Ok("Stop simulation!");
            Console.WriteLine();

            this.stopButton.Enabled = false;
            this.startButton.Enabled = true;

            this.simulationForm.Close();
            this.tokenSource.Cancel();
        }

        private async void devices_button_Click(object sender, EventArgs e)
        {

            ErrorForm errorForm = new ErrorForm();
            errorForm.Text = "Error";
            errorForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            errorForm.setSext("Error null pointer");

            this.listbox_devices.Items.Clear();

            Log.Ok("Get all devices...");
            List<JObject> devices = await DeviceOperationsApi.GetDevices();
            foreach (var device in devices)
            {
                this.listbox_devices.Items.Add(device["deviceId"]);
            }
        }

        private async void listbox_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listbox_devices.Items.Count > 0)
            {
                Log.Ok("Click on: " + this.listbox_devices.SelectedItem.ToString());
          
                string connection = await DeviceOperationsApi.GetStringConnection(this.listbox_devices.SelectedItem.ToString());
                this.deviceHub = new Device(connection);

                this.startButton.Enabled = true;
            }
        }

        private void DevicesTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
