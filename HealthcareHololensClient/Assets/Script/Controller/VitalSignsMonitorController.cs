using Azure.DigitalTwins.Core;
using AzureDigitalTwins;
using System.Text;
using System.Threading.Tasks;

public class VitalSignsMonitorController : BaseApplicationPanel
{
    private string deviceId;
    private PanelType lastSelectedPanelType;
    private bool receivedFirstMessage = false;
    private DigitalTwinsClient digitalTwinClient;

    private void Start()
    {
        this.digitalTwinClient = TwinOperationApi.GetClient();
    }

    public VitalSignsMonitorController()
    {
        this.deviceId = "PGNLNZ97M18G479M";
        this.lastSelectedPanelType = PanelType.Home;
    }

    public async void OnDataReceived(Message message) {
        this.deviceId = message.device_id;

        if (!this.receivedFirstMessage)
        {
            receivedFirstMessage = true;
            await this.InitSelectedViewAsync();
            await App.PatientView.Initialize();
        }

        App.VitalSignsMonitorView.UpdateView(message);
        App.HeartFrequencyView.UpdateView(message);
        App.BreathFrequencyView.UpdateView(message);
        App.SaturationView.UpdateView(message);
        App.BloodPressureView.UpdateView(message);
        App.SensorValuesView.UpdateView(message);

        var selectedPanel = (PanelType)message.configuration_last_selected_view;

        if (lastSelectedPanelType != selectedPanel)
        {
            App.ButtonMenuView.UpdateSelectedPanel(selectedPanel);
            lastSelectedPanelType = selectedPanel;
        }
    }
    public async Task PersistSelectedPanel(PanelType selectedPanel)
    {
        if (deviceId != null && deviceId != "")
        {
            await TwinOperationApi.SetSelectedView(digitalTwinClient, deviceId, selectedPanel);
        }
    }

    private static Microsoft.Azure.Devices.Client.Message CreateMessage(string jsonObject)
    {
        var message = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(jsonObject))
        {
            ContentType = "application/json",
            ContentEncoding = "UTF-8"
        };

        return message;
    }

    public async Task<Patient> GetPatientAsync()
    {
        return await TwinOperationApi.GetPatient(digitalTwinClient, deviceId);
    }

    private async Task InitSelectedViewAsync()
    {
        var selectedPanel = await TwinOperationApi.GetSelectedView(digitalTwinClient, deviceId);
        App.ButtonMenuView.UpdateSelectedPanel(selectedPanel);
    }
}