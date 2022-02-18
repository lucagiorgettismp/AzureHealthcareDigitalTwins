namespace Client.View
{
    using Common.Utils;
    using Controller;
    using System;
    using System.Windows.Forms;

    public partial class ClientForm : Form
    {
        readonly Client clientTwins;

        public ClientForm()
        {
            InitializeComponent();
            this.clientTwins = new Client();
        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm(this, this.clientTwins)
            {
                Text = "Patient",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            patientForm.Show();
            this.Enabled = false;
        }

        private async void GetTwinsButtonClick(object sender, EventArgs e)
        {
            this.patients_twins_collections.Items.Clear();

            var twins = await this.clientTwins.GetTwins();
            for(int i = 0; i < twins.Count; i++)
            {
                this.patients_twins_collections.Items.Add(twins[i]);
            }
        }

        private void SelectedIndexPatients(object sender, EventArgs e)
        {
            Log.Ok("Click on: " + patients_twins_collections.SelectedItem.ToString());
        }
    }
}
