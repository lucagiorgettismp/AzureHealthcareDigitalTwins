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
    
    private VitalSignsMonitorModel Model;
    private string deviceId = null;
    private PanelType lastSelectedPanelType;
    private DigitalTwinsClient digitalTwinClient;

    private Application Application;
    
    public void Start()
    {
        this.lastSelectedPanelType = PanelType.Home;
        this.Application = GameObject.FindObjectOfType<Application>();

        this.Model = new VitalSignsMonitorModel(this);
    }

    public void Init()
    {
        this.View.Start();
        this.View.HideAllPanels();
    }

    public async Task OnStartController(string deviceId)
    {
        Debug.Log($"[OnStartController], calling...");
        try
        {
            this.View.StartLoading();
            this.deviceId = deviceId;
            this.digitalTwinClient = TwinOperationApi.GetClient();

            this.Model.Init(deviceId);

            await this.GetPatientAsync();
            await this.GetSelectedViewAsync();
        }catch(Exception e)
        {
            Debug.LogError($"[OnStartController], Errror: {e.Message}");
        }
    }

    public void OnDataReceived(Message message) {

        this.View.UpdateData(message);

        var selectedPanel = (PanelType)message.configuration_last_selected_view;

        if (lastSelectedPanelType != selectedPanel)
        {
            this.View.SetSelectedPanel(selectedPanel);
            lastSelectedPanelType = selectedPanel;
        }
    }

    public async Task PersistSelectedPanel(PanelType selectedPanel)
    {
        if (deviceId != null && deviceId.Length > 0)
        {
            await TwinOperationApi.SetSelectedView(digitalTwinClient, deviceId, selectedPanel);
        }
    }

    public async Task GetPatientAsync()
    {
        this.View.SetPatientPanelLoading();

        var patient = await TwinOperationApi.GetPatient(digitalTwinClient, deviceId);

        this.View.StopLoading();
        this.View.SetPatient(patient);
    }

    private async Task GetSelectedViewAsync()
    {
        var selectedPanel = await TwinOperationApi.GetSelectedView(digitalTwinClient, deviceId);
        this.View.StopLoading();
        this.View.SetSelectedPanel(selectedPanel);
    }

    internal void CloseApplication()
    {
        this.Application.Close();
    }
}
    