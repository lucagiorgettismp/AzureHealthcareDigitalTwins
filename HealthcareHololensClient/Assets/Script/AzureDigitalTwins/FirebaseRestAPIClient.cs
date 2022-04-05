using Assets.Script.Model;
using Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using UnityEngine;

public class FirebaseRestAPIClient
{
    private const string BASE_URL = "https://azurehealtcaredigitaltwins-default-rtdb.europe-west1.firebasedatabase.app";
    private const string TOKEN = "0vPOYNsGqCQVKU9s7g2Ko3wBxj4qIBmxak1CDtxg";
    private readonly RestClient client;

    public FirebaseRestAPIClient()
    {
        client = new RestClient(BASE_URL);
    }

    internal async Task<Patient> GetPatientAsync(string deviceId)
    {
        var request = new RestRequest($"/patients/{deviceId}.json", Method.GET);
        request.AddParameter("auth", TOKEN);
        var result = await client.GetAsync<Patient>(request);
        return result;
    }

    internal async Task<int> GetSelectedViewAsync(string deviceId)
    {
        var request = new RestRequest($"/devices/{deviceId}/configuration/lastselectedview.json", Method.GET);
        request.AddParameter("auth", TOKEN);
        var result = await client.GetAsync<int>(request);
        return result;
    }

    internal void SetSelectedView(string deviceId, PanelType panel)
    {
        try
        {
            var request = new RestRequest($"/devices/{deviceId}.json?auth=0vPOYNsGqCQVKU9s7g2Ko3wBxj4qIBmxak1CDtxg", Method.PUT);
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(
                new DevicePayload
                {
                    Configuration = new ConfigurationPayloadData
                    {
                        LastSelectedView = (int)panel
                    }
                });

            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
}