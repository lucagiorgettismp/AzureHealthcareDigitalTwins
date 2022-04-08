using Azure.DigitalTwins.Core;
using Client.AzureApi;
using Client.AzureApi.Models;
using Client.View;
using Common.AzureApi;
using Common.Utils;
using Common.View;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.src.Controller
{
    public class PatientController
    {
        private readonly PatientForm _view;
        private readonly SuccessForm _successForm;
        private readonly ErrorForm _errorForm;
        private readonly DigitalTwinsClient _twinClient;
        private readonly Action _onClose;

        public PatientController(Action onClose)
        {
            this._onClose = onClose;
            this._view = new PatientForm(this)
            {
                Text = "Patient",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            this._errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            this._successForm = new SuccessForm(() => this._view.Hide())
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            try
            {
                this._twinClient = AuthenticationApi.GetClient();
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                this._errorForm.SetText(e.Message);
                this._errorForm.Show();
            }
        }

        internal void OnClose()
        {
            this.Close();
            this._onClose();
        }

        public void Close()
        {
            this._view.Hide();
        }

        internal void Start()
        {
            _view.Show();
        }

        public async Task CreatePatient(PatientModel model)
        {
            try
            {
                await new TwinOperationsApi().CreatePatient(_twinClient, model);
                new FirebaseRestAPIClient().CreatePatient(model);

                this._successForm.SetText("Patient added successfully!");
                this._successForm.Show();
            }
            catch (Exception e)
            {
                Log.Error(e.Message);

                this._errorForm.SetText(e.Message);
                this._errorForm.Show();
            }
        }
    }
}
