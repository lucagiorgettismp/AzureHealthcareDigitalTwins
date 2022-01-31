namespace Simulator.View
{
    using Common.Enums;
    using Common.Utils;
    using Controller;
    using Newtonsoft.Json.Linq;
    using Simulator.AzureApi;
    using Simulator.src;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;

    public partial class ControlPanelForm : Form
    {
        Device deviceHub;
        CancellationTokenSource tokenSource;

        SimulationForm simulationForm;
        bool simulatorIsInRunning;

        public ControlPanelForm()
        {
            InitializeComponent();
            this.deviceHub = new Device();
            this.simulatorIsInRunning = false;
        }

        // Start button simulator 
        private async void start_button_click(object sender, EventArgs e)
        {
            if (!this.simulatorIsInRunning)
            {
                this.simulatorIsInRunning = true;
                Log.Ok("Start simulation!");
                Console.WriteLine();

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
            if (this.simulatorIsInRunning)
            {
                this.simulatorIsInRunning = false;
                Log.Ok("Stop simulation!");
                Console.WriteLine();

                this.simulationForm.Close();
                this.tokenSource.Cancel();
            }
        }

        private void tableMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void devices_button_Click(object sender, EventArgs e)
        {
            this.listbox_devices.Items.Clear();

            Log.Ok("Get all devices...");
            List<JObject> devices = await DeviceOperationsApi.getDevices();
            foreach (var device in devices)
            {
                this.listbox_devices.Items.Add(device["deviceId"]);
            }
        }

        private void listbox_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log.Ok("Click on: " + this.listbox_devices.SelectedItem.ToString());
        }
    }
}
