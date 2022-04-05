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
        var request = new RestRequest($"{BASE_URL}/patients/{deviceId}.json", Method.Get);
        request.AddParameter("auth", TOKEN);
        var result = await client.GetAsync<Patient>(request);
        return result;
    }

    internal async Task<PanelType> GetSelectedViewAsync(string deviceId)
    {
        var request = new RestRequest($"{BASE_URL}/devices/{deviceId}/configuration/lastselectedview.json", Method.Get);
        request.AddParameter("auth", TOKEN);
        var result = await client.GetAsync<PanelType> (request);
        return result;
    }
            
    internal async Task SetSelectedViewAsync(string deviceId, PanelType panel)
    {
        try
        {
            var request = new RestRequest($"{BASE_URL}/devices/{deviceId}.json", Method.Put);
            var body = new DevicePayload
            {
                Configuration = new ConfigurationPayloadData
                {
                    LastSelectedView = (int)panel
                }
            };
                
            var json = JsonConvert.SerializeObject(body);
            Debug.Log(json);

            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(body), ParameterType.RequestBody);

            //request.RequestFormat = DataFormat.Json;
            //request.AddJsonBody(json);
            request.AddParameter("auth", TOKEN);    
            var result = await client.ExecuteAsync(request);

            Debug.Log(result.ResponseStatus);
            Debug.Log(result.ErrorMessage);
        }
        catch(Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
}