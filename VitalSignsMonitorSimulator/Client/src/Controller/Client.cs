namespace Client.Controller
{
    using Azure.DigitalTwins.Core;
    using AzureApi;
    using AzureApi.Models;
    using Common.Utils;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class Client
    {
        private readonly DigitalTwinsClient twinClient;
        private readonly TwinOperationsApi op;

        public Client()
        {
            this.twinClient = AuthenticationApi.GetClient();
            this.op = new TwinOperationsApi();
        }

        public async Task<List<string>> GetTwins() {
            return await this.op.GetTwins(this.twinClient);
        }

        public async void CreatePatientTwin(PatientModel model)
        {
            try
            {
                await this.op.CreatePatientTwin(twinClient, model);
            }catch(Exception e)
            {
                Log.Error(e.Message);
            }
        }
    }
}
