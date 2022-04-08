using Assets.Script.Model;
using Assets.Script.View;
using System;
using System.Threading.Tasks;
using UnityEngine;

public class VitalSignsMonitorController: MonoBehaviour
{
    public VitalSignsMonitorView View;
    
    private VitalSignsMonitorModel _model;
    private string _deviceId = null;
    private PanelType _lastSelectedPanelType;
    private Application _application;
    private FirebaseRestAPIClient firebaseApiClient;

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

    public void PersistSelectedPanel(PanelType selectedPanel)
    {
        if (_deviceId != null && _deviceId.Length > 0)
        {
            firebaseApiClient.SetSelectedView(_deviceId, selectedPanel);
        }
    }

    public async Task GetPatientAsync()
    {
        try
        {
            var patient = await this.firebaseApiClient.GetPatientAsync(_deviceId);

            this.View.StopLoading();
            this.View.SetPatient(patient);
        }catch(Exception e)
        {
            Debug.LogError($"Error GetPatientAsync: {e.Message}");
        }
    }

    private async Task GetSelectedViewAsync()
    {
        try { 
            var configuration =  await this.firebaseApiClient.GetConfigurationAsync(_deviceId);
            this.View.StopLoading();    
            this.View.SetSelectedPanel((PanelType)configuration.LastSelectedView);
        }
        catch (Exception e)
        {
            Debug.LogError($"Error GetSelectedViewAsync: {e.Message}");
        }
    }

    internal void CloseApplication()
    {
        this._application.Close();
    }
}