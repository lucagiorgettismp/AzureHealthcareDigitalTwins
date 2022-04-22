namespace Client.View
{
    using Controller;
    using Models;
    using Common.Utils;
    using System;
    using System.Windows.Forms;

    public partial class PatientForm : Form
    {
        private readonly PatientController _controller;

        public PatientForm(PatientController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Parent = null;

            this._controller.OnClose();
        }

        private void NumberFieldKeyPress(object sender, KeyPressEventArgs e)
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

        private async void SavePatientButtonClick(object sender, EventArgs e)
        {
            if (this.patient_name.Text.Trim() != "" && this.patient_surname.Text.Trim() != "" &&
                this.patient_age.Text.Trim() != "" && this.patient_gender.Text.Trim() != "" &&
                this.patient_height.Text.Trim() != "" && this.patient_weight.Text.Trim() != "" &&
                this.patient_description.Text.Trim() != "" && this.patient_body_mass_index.Text.Trim() != "" &&
                this.patient_fiscal_code.Text.Trim() != "")
            {
                Log.Ok("Create a twin");
                var patientModel = new PatientModel
                {
                    Name = this.patient_name.Text,
                    Surname = this.patient_surname.Text,
                    Age = Convert.ToInt32(this.patient_age.Text),
                    Gender = this.patient_gender.Text,
                    Height = Convert.ToDouble(this.patient_height.Text.Replace(".", ",")),
                    Weight = Convert.ToDouble(this.patient_weight.Text.Replace(".", ",")),
                    Description = this.patient_description.Text,
                    BodyMassIndex = Convert.ToDouble(this.patient_body_mass_index.Text.Replace(".", ",")),
                    FiscalCode = this.patient_fiscal_code.Text
                };

                await this._controller.CreatePatient(patientModel);
            }
        }

        private void PatientGenderKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
