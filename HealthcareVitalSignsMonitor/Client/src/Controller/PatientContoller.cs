using Common.Utils.Exceptions;

namespace Client.Controller
{
    using Azure.DigitalTwins.Core;
    using Api;
    using Models;
    using View;
    using Common.AzureApi;
    using Common.Utils;
    using Common.View;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class PatientController
    {
        private PatientForm _view;
        private readonly SuccessForm _successForm;
        private readonly ErrorForm _errorForm;
        private readonly DigitalTwinsClient _twinClient;
        private readonly Action _onClose;

        public PatientController(Action onClose)
        {
            this._onClose = onClose;

            this._errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._successForm = new SuccessForm(() => this._view.Hide())
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            try
            {
                this._twinClient = AuthenticationApi.GetClient();
            }
            catch (Exception e) when (e is AppSettingsReadingException || e is ClientAuthenticationException)
            {
                Log.Error(e.Message);
                this._errorForm.SetText(e.Message);
                this._errorForm.Show();
            }
        }

        internal void OnClose()
        {
            this._onClose();
        }

        public void Close()
        {
            if (this._view != null)
            {
                this._view.Close();
            }
        }

        internal void Start()
        {
            this._view = new PatientForm(this)
            {
                Text = "Patient",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._view.Show();
        }

        public async Task CreatePatient(PatientModel model)
        {
            try
            {
                await new TwinOperationsApi().CreatePatient(_twinClient, model);
                new FirebaseRestApiClient().CreatePatient(model);

                this._successForm.SetText("Patient added successfully!");
                this._successForm.Show();
                this._onClose();
            }

            catch (Exception e) when (e is PatientTwinCreationException || e is FirebaseCreatePatientException)
            {
                Log.Error(e.Message);
                this._errorForm.SetText(e.Message);
                this._errorForm.Show();
            }
        }
    }
}
