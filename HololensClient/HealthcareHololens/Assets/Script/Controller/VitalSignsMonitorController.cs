using AzureDigitalTwins;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;

public class VitalSignsMonitorController : BaseApplicationPanel
{
    private string deviceId;

    public void OnDataReceived(Message message) {
        App.VitalSignsMonitorView.UpdateView(message);
        App.HeartFrequencyView.UpdateView(message);
        App.BreathFrequencyView.UpdateView(message);
        App.SaturationView.UpdateView(message);
        App.BloodPressureView.UpdateView(message);
        App.SensorValuesView.UpdateView(message);

        App.ButtonMenuView.UpdateSelectedPanel((PanelType)message.configuration_last_selected_view);
        this.deviceId = message.device_id;
    }
    public async Task PersistSelectedPanel(PanelType selectedPanel)
    {
        // TODO: setup deviceId
        var connection = await DeviceOperationsApi.GetConnectionString(deviceId);
        var deviceClient = DeviceClient.CreateFromConnectionString(connection);

        var configuration = new Configuration
        {
            LastSelectedView = (int)selectedPanel
        };

        await deviceClient.SendEventAsync(CreateMessage(JsonConvert.SerializeObject(configuration)));
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

    [Serializable]
    private class Configuration
    {
        [JsonProperty("last_selected_view")]
        public int LastSelectedView { get; set; }
    }
}
    