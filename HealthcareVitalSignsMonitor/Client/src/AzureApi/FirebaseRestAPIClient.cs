using Client.AzureApi.Models;
using Client.src.AzureApi.DTLDModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;

public class FirebaseRestAPIClient
{
    private readonly RestClient _client;
    private readonly string _authToken;

    public FirebaseRestAPIClient()
    {

        var appSettings = ConfigurationManager.AppSettings;

        this._authToken = appSettings["FirebaseAuth"];
        var baseUrl = appSettings["FirebaseDatabaseBaseUrl"];

        _client = new RestClient(baseUrl);
    }

    public void CreatePatient(PatientModel patient)
    {
        var request = new RestRequest($"/patients/{patient.FiscalCode}.json?auth={_authToken}", Method.PUT);
        request.AddHeader("Content-Type", "application/json");

        var dbModel = new PatientTwin(patient);

        var body = JsonConvert.SerializeObject(dbModel);

        request.AddParameter("application/json", body, ParameterType.RequestBody);
        IRestResponse response = _client.Execute(request);
        Console.WriteLine(response.Content);
    }
}