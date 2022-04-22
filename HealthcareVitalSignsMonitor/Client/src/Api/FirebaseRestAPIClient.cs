using Common.Utils.Exceptions;

namespace Client.Api
{
    using Common.Utils.Exceptions;
    using DTLDModels;
    using Models;
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Configuration;

    public class FirebaseRestApiClient
    {
        private readonly RestClient _client;
        private readonly string _authToken;

        public FirebaseRestApiClient()
        {
            var appSettings = ConfigurationManager.AppSettings;

            this._authToken = appSettings["FirebaseAuth"];
            var baseUrl = appSettings["FirebaseDatabaseBaseUrl"];

            _client = new RestClient(baseUrl);
        }

        /// <exception cref="FirebaseCreatePatientException"/>
        public void CreatePatient(PatientModel patient)
        {
            try
            {
                var request = new RestRequest($"/patients/{patient.FiscalCode}.json?auth={_authToken}", Method.PUT);
                request.AddHeader("Content-Type", "application/json");

                var dbModel = new PatientTwin(patient);

                var body = JsonConvert.SerializeObject(dbModel);

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = _client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception e)
            {
                throw new FirebaseCreatePatientException(e);
            }
        }
    }
}