using Simulator.AzureApi.Models;
using Simulator.Simulator.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator
{
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

                var modelPatient = new PatientModel();
                modelPatient.Name = this.patient_name.Text;
                modelPatient.Surname = this.patient_surname.Text;
                modelPatient.Age = Convert.ToInt32(this.patient_age.Text);
                modelPatient.Gender = this.patient_gender.Text;
                modelPatient.Height = Convert.ToDouble(this.patient_height.Text);
                modelPatient.Weight = Convert.ToDouble(this.patient_weight.Text);
                modelPatient.Description = this.patient_description.Text;
                modelPatient.BodyMassIndex = Convert.ToDouble(this.patient_body_mass_index.Text);

                this.clientTwins.createPatientTwin(modelPatient);
            }
        }

        private void patient_gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
