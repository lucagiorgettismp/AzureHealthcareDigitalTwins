using Azure.DigitalTwins.Core;
using Simulator.AzureApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Simulator.Controller
{
    public class Client
    {
        private DigitalTwinsClient twinClient;
        private TwinOperationsApi op;

        public Client()
        {
            this.twinClient = AuthenticationApi.GetClient();
            this.op = new TwinOperationsApi();
        }

        public async Task<List<String>> getTwins() {
            return await this.op.getTwins(this.twinClient);
        }

        public async void createPatientTwin(PatientModel model)
        {
            await this.op.createPatientTwin(twinClient, model);
        }
    }
}
