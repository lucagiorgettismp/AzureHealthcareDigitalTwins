namespace Client.Controller
{
    using Api;
    using Azure.DigitalTwins.Core;
    using Common.AzureApi;
    using Common.Utils;
    using Common.Utils.Exceptions;
    using Common.View;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using View;

    internal class DigitalTwinsController
    {
        private readonly DigitalTwinsForm _view;
        private readonly Action _onAddPatientClick;
        private readonly Action _onClose;
        private readonly ErrorForm _errorForm;
        private readonly SuccessForm _successForm;
        private readonly DigitalTwinsClient _twinClient;

        public DigitalTwinsController(Action onAddPatientClick, Action onClose)
        {
            this._view = new DigitalTwinsForm(this)
            {
                Text = "Digital Twins",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._onAddPatientClick = onAddPatientClick;
            this._onClose = onClose;

            this._errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            this._successForm = new SuccessForm()
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            try
            {
                this._twinClient = AuthenticationApi.GetClient();
            }
            catch (ClientAuthenticationException e)
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

        internal void Start()
        {
            Application.Run(_view);
        }

        internal void OnNewPatientClick()
        {
            this._view.Enabled = false;
            this._onAddPatientClick();
        }

        internal void Enable()
        {
            this._view.Enabled = true;
        }

        public async Task<List<string>> GetDigitalTwins()
        {
            var list = await new TwinOperationsApi().GetTwins(this._twinClient);

            var message = list.Count == 0 ? "No patients found." : "Patients retrieved.";

            this._successForm.SetText(message);
            this._successForm.Show();

            return list;
        }
    }
}
