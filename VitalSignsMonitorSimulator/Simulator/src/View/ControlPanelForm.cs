﻿namespace Simulator.View
{
    using Common.Enums;
    using Common.Utils;
    using Controller;
    using Simulator.src;
    using System;
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
        private void stop_button_Click(object sender, EventArgs e)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
