namespace Client.View
{
    using AzureApi.Models;
    using Controller;
    using System;
    using System.Windows.Forms;

    public partial class PatientForm : Form
    {
        Client clientTwins;

        public PatientForm(Client client)
        {
            InitializeComponent();
            this.clientTwins = client;
        }

        private void patient_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void patient_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_surname_Click(object sender, EventArgs e)
        {

        }

        private void label_age_Click(object sender, EventArgs e)
        {

        }

        private void label_gender_Click(object sender, EventArgs e)
        {

        }

        private void label_description_Click(object sender, EventArgs e)
        {

        }

        private void label_body_mass_index_Click(object sender, EventArgs e)
        {

        }

        private void patient_name_TextChanged_1(object sender, EventArgs e)
        {}

        private void patient_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void patient_height_TextChanged(object sender, EventArgs e)
        {

        }

        private void patient_age_KeyPress(object sender, KeyPressEventArgs e)
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

        private void patient_height_KeyPress(object sender, KeyPressEventArgs e)
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

        private void patient_weight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void patient_body_mass_index_KeyPress(object sender, KeyPressEventArgs e)
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

        private void save_patient_button_Click(object sender, EventArgs e)
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

        private void patient_gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
