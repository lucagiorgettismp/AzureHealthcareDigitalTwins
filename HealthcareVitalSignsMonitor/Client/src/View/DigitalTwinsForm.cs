namespace Client.View
{
    using Controller;
    using Common.Utils;
    using System;
    using System.Windows.Forms;

    partial class DigitalTwinsForm : Form
    {
        private readonly DigitalTwinsController _controller;

        public DigitalTwinsForm(DigitalTwinsController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            _controller.OnNewPatientClick();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this._controller.OnClose();

            base.OnFormClosing(e);
        }

        private async void GetTwinsButtonClick(object sender, EventArgs e)
        {
            this.patients_twins_collections.Items.Clear();

            this.patients_twins_collections.Items.Add("Getting all patients");
            this.patients_twins_collections.Enabled = false;

            var twins = await this._controller.GetDigitalTwins();

            this.patients_twins_collections.Items.Clear();
            this.patients_twins_collections.Enabled = true;

            this.patients_twins_collections.Items.AddRange(twins.ToArray());
        }

        private void SelectedIndexPatients(object sender, EventArgs e)
        {
            try
            {
                if (this.patients_twins_collections.SelectedItem != null)
                {
                    Log.Ok("Click on: " + patients_twins_collections.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
    }
}
