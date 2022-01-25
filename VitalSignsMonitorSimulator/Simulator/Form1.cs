using Simulator.Simulator;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator
{
    public partial class Form1 : Form
    {
        Device deviceHub;

        public Form1()
        {
            InitializeComponent();
            this.deviceHub = new Device();
        }

        private async void start_button_click(object sender, EventArgs e)
        {
            Console.WriteLine("Click button start!");

            var tokenSource = new CancellationTokenSource();
            await this.deviceHub.SendMessageToIoTHub(tokenSource.Token);
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click button create!");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patients_twins_collections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
