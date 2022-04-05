using Assets.Script.Model;
using Assets.Script.View;
using Azure.DigitalTwins.Core;
using AzureDigitalTwins;
using System;
using System.Threading.Tasks;
using UnityEngine;

public class VitalSignsMonitorController: MonoBehaviour
{
    public VitalSignsMonitorView View;
    
    private VitalSignsMonitorModel _model;
    private string _deviceId = null;
    private PanelType _lastSelectedPanelType;
    private DigitalTwinsClient _digitalTwinClient;
    private Application _application;
    private FirebaseRestAPIClient firebaseApiClient;

    private string _connectionString;
    private const string FILE_NAME = "appsettings";

    public void Awake()
    {
        this._connectionString = Resources.Load<TextAsset>(FILE_NAME).text;
    }

    public void Start()
    {
        this._lastSelectedPanelType = PanelType.Home;
        this._application = GameObject.FindObjectOfType<Application>();

        this._model = new VitalSignsMonitorModel(this);

        this.View.Start();
        this.View.HideAllPanels();

        this.View.StartLoading();

        this.firebaseApiClient = new FirebaseRestAPIClient();
    }

    public async Task OnStartController(string deviceId)
    {
        Debug.Log($"[OnStartController], calling...");
        try
        {
            this._deviceId = deviceId;
            //this._digitalTwinClient = TwinOperationApi.GetClient(this._connectionString);
                    
            this._model.Init(deviceId);

            await this.GetPatientAsync();
            await this.GetSelectedViewAsync();
        }catch(Exception e)
        {
            Debug.LogError($"[OnStartController], Error: {e.Message}");
        }
    }

    public void OnDataReceived(Message message) {

        this.View.UpdateData(message);

        var selectedPanel = (PanelType)message.configuration_last_selected_view;

        if (_lastSelectedPanelType != selectedPanel)
        {
            this.View.SetSelectedPanel(selectedPanel);
            _lastSelectedPanelType = selectedPanel;
        }
    }

    public async Task PersistSelectedPanel(PanelType selectedPanel)
    {
        if (_deviceId != null && _deviceId.Length > 0)
        {
            await firebaseApiClient.SetSelectedViewAsync(_deviceId, selectedPanel);
            //await TwinOperationApi.SetSelectedView(_digitalTwinClient, _deviceId, selectedPanel);
        }
    }

    public async Task GetPatientAsync()
    {
        //var patient = await TwinOperationApi.GetPatient(_digitalTwinClient, _deviceId);
        var patient = await this.firebaseApiClient.GetPatientAsync(_deviceId);

        this.View.StopLoading();
        this.View.SetPatient(patient);
    }

    private async Task GetSelectedViewAsync()
    {
        //var selectedPanel = await TwinOperationApi.GetSelectedView(_digitalTwinClient, _deviceId);
        var selectedPanel = (PanelType) await this.firebaseApiClient.GetSelectedViewAsync(_deviceId);
        this.View.StopLoading();    
        this.View.SetSelectedPanel(selectedPanel);
    }

    internal void CloseApplication()
    {
        this._application.Close();
    }
}