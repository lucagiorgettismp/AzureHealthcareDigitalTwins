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
        private const string DEVICE_ID = "deviceId";

        public ControlPanelForm()
        {
            InitializeComponent();
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

            Log.Ok("Get all devices...");
            List<JObject> devices = await DeviceOperationsApi.GetDevices();
            foreach (var device in devices)
            {
                this.listbox_devices.Items.Add(device[DEVICE_ID]);
            }
        }

        private async void SelectedIndexDevices(object sender, EventArgs e)
        {
            if (this.listbox_devices.Items.Count > 0)
            {
                Log.Ok("Click on: " + this.listbox_devices.SelectedItem.ToString());
          
                string connection = await DeviceOperationsApi.GetStringConnection(this.listbox_devices.SelectedItem.ToString());
                this.deviceHub = new Device(connection);

                this.startButton.Enabled = true;
            }
        }
    }
}
