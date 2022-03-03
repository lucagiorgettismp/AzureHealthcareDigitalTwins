namespace Client.Controller
{
    using Azure.DigitalTwins.Core;
    using AzureApi;
    using AzureApi.Models;
    using Common;
    using Common.Utils;
    using Common.View;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class Client
    {
        private readonly DigitalTwinsClient twinClient;
        private readonly TwinOperationsApi op;

        private SuccessForm successForm;
        private ErrorForm errorForm;

        public Client()
        {
            try
            {
                this.twinClient = AuthenticationApi.GetClient();
            }catch (Exception e)
            {
                Log.Error(e.Message);
                this.errorForm.SetText(e.Message);
                this.errorForm.Show();
         
            }

            this.op = new TwinOperationsApi();

            this.errorForm = new ErrorForm()
            {
                Text = "Error",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            this.successForm = new SuccessForm()
            {
                Text = "Success",
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
        }

        public async Task<List<string>> GetTwins() {
            List<string> list = await this.op.GetTwins(this.twinClient);

            string message;
            if(list.Count == 0)
            {
                message = "No digital twins found.";
            }
            else
            {
                message = "Digital twins found!";
            }

            this.successForm.SetText(message);
            this.successForm.Show();

            return list;
        }

        public async Task<bool> CreatePatientTwin(PatientModel model)
        {
            try
            {
                await this.op.CreatePatientTwin(twinClient, model);

                this.successForm.SetText("Patient added successfully!");
                this.successForm.Show();
            }
            catch(Exception e)
            {
                Log.Error(e.Message);

                this.errorForm.SetText(e.Message);
                this.errorForm.Show();
                return false;
            }
            return true;
        }
    }
}
