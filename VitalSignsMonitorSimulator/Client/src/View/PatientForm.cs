namespace Client.View
{
    using AzureApi.Models;
    using Controller;
    using System;
    using System.Windows.Forms;

    public partial class PatientForm : Form
    {
        readonly Client clientTwins;

        public PatientForm(Client client)
        {
            InitializeComponent();
            this.clientTwins = client;
        }

        private void PatientAgeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PatientHeightKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PatientWeightKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PatientBodyMassIndexKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SavePatientButtonClick(object sender, EventArgs e)
        {

            if (this.patient_name.Text.Trim() != "" && this.patient_surname.Text.Trim() != "" &&
                this.patient_age.Text.Trim() != "" && this.patient_gender.Text.Trim() != "" &&
                this.patient_height.Text.Trim() != "" && this.patient_weight.Text.Trim() != "" &&
                this.patient_description.Text.Trim() != "" && this.patient_body_mass_index.Text.Trim() != "") {

                var modelPatient = new PatientModel
                {
                    Name = this.patient_name.Text,
                    Surname = this.patient_surname.Text,
                    Age = Convert.ToInt32(this.patient_age.Text),
                    Gender = this.patient_gender.Text,
                    Height = Convert.ToDouble(this.patient_height.Text),
                    Weight = Convert.ToDouble(this.patient_weight.Text),
                    Description = this.patient_description.Text,
                    BodyMassIndex = Convert.ToDouble(this.patient_body_mass_index.Text)
                };

                this.clientTwins.CreatePatientTwin(modelPatient);
                this.Close();
            }
        }

        private void PatientGenderKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
