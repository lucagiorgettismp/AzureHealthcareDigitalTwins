namespace View
{
    using Controller;
    using System;
    using System.Windows.Forms;
    using Utils;

    public partial class ClientForm : Form
    {
        readonly Client clientTwins;

        public ClientForm()
        {
            InitializeComponent();
            this.clientTwins = new Client();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm(this.clientTwins);
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
