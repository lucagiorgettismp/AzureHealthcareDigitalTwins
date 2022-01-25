using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Simulator.Controller
{
    class Client
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

        public async void createPatientTwin(
            string name,
            string surname,
            int age,
            string gender,
            double height,
            double weight,
            string description,
            double bmi)
        {
            await this.op.createPatientTwin(twinClient, name, surname, age, gender, height, weight, description, bmi);
        }
    }
}
