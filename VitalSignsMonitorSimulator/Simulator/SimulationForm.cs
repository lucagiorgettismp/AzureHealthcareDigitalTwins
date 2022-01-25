using Simulator.Simulator;
using Simulator.Simulator.Controller;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Simulator
{
    public partial class SimulationForm : Form
    {
        Device deviceHub;
        Client clientTwins; 
        CancellationTokenSource tokenSource;

        bool simulatorIsInRunning;

        public SimulationForm()
        {
            InitializeComponent();
            this.deviceHub = new Device();
            this.clientTwins = new Client();

            this.tokenSource = new CancellationTokenSource();
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

                var tokenSource = new CancellationTokenSource();
                await this.deviceHub.SendMessageToIoTHub(tokenSource.Token, Simulator.Model.CrudMode.Update);
            }
        }

        // Stop button simulator
        private void stop_button_Click(object sender, EventArgs e)
        {
            if (this.simulatorIsInRunning)
            {
                this.simulatorIsInRunning = false;
                Log.Ok("Stop simulation!");
                Console.WriteLine();

                this.tokenSource.Cancel();
            }
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Text = "Patient";
            patientForm.Show();
        }

        private async void get_twins_button_Click(object sender, EventArgs e)
        {
            var twins = await this.clientTwins.getTwins();
            for(int i = 0; i < twins.Count; i++)
            {
                this.patients_twins_collections.Items.Add(twins[i]);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patients_twins_collections_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log.Ok("Click on: " + patients_twins_collections.SelectedItem.ToString());
        }
    }
}
