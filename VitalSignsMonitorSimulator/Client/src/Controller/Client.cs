namespace Controller
{
    using Azure.DigitalTwins.Core;
    using AzureApi;
    using AzureApi.Models;
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

        public async Task<List<string>> getTwins() {
            return await this.op.getTwins(this.twinClient);
        }

        public async void createPatientTwin(PatientModel model)
        {
            await this.op.createPatientTwin(twinClient, model);
        }
    }
}
