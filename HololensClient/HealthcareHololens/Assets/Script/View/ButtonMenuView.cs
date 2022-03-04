using AzureDigitalTwins;
using Microsoft.Azure.Devices.Client;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuView : BaseApplicationPanel
{

    private PanelWrapper[] panels;
    private DeviceClient deviceClient;


    void Start()
    {
        // TODO: setup deviceId
        var deviceId = "";
        var connection = DeviceOperationsApi.GetConnectionString(deviceId);
        this.deviceClient = DeviceClient.CreateFromConnectionString(connection);

        List<PanelWrapper> panelList = new List<PanelWrapper>
        {
            new PanelWrapper { Panel = GameObject.Find("VitalSignsMonitorPanel"), PanelType = PanelType.Home},
            new PanelWrapper { Panel = GameObject.Find("HeartFrequencyPanel"), PanelType = PanelType.HeartFrequency},
            new PanelWrapper { Panel = GameObject.Find("BreathFrequencyPanel"), PanelType = PanelType.BreathFrequency},
            new PanelWrapper { Panel = GameObject.Find("SaturationPanel"), PanelType = PanelType.Saturation},
            new PanelWrapper { Panel = GameObject.Find("BloodPressurePanel"), PanelType = PanelType.BloodPressure},
            new PanelWrapper { Panel = GameObject.Find("SensorValuesPanel"), PanelType = PanelType.Values}
        };

        panels = panelList.ToArray();

        this.SelectPanel(PanelType.Home, false);
    }

    private void SelectPanel(PanelType selectedPanel, bool notifyServer = true)
    {

        foreach (var panel in panels)
        {
            if (panel.PanelType == selectedPanel)
            {
                panel.Panel.gameObject.transform.position = GetCurrentPosition();

            }

            panel.Panel.gameObject.SetActive(panel.PanelType == selectedPanel);
        }

        if (notifyServer)
        {
            // TODO: Notify DT
        }
    }

    public void OnClickHomeButton()
    {
        Debug.Log("Home button has been pressed!");

        this.SelectPanel(PanelType.Home, true);
    }

    public void OnClickHeartFrequencyButton()
    {
        Debug.Log("Heart frequency button has been pressed!");

        this.SelectPanel(PanelType.HeartFrequency);
    }

    public void OnClickBreathFrequencyButton()
    {
        Debug.Log("Breath frequency button has been pressed!");

        this.SelectPanel(PanelType.BreathFrequency);
    }

    public void OnClickSaturationButton()
    {
        Debug.Log("Saturation button has been pressed!");

        this.SelectPanel(PanelType.Saturation);
    }

    public void OnClickBloodPressureButton()
    {
        Debug.Log("Blood Pressure button has been pressed!");

        this.SelectPanel(PanelType.BloodPressure);
    }

    public void OnClickValuesButton()
    {
        Debug.Log("Values button has been pressed!");

        this.SelectPanel(PanelType.Values);
    }

    public void OnClickCloseButton()
    {
        Debug.Log("Close button has been pressed!");
        App.Close();
    }

    private Vector3 GetCurrentPosition()
    {
        Vector3 currentPosition = this.transform.position;
        return new Vector3(currentPosition.x + 0.035f, currentPosition.y + 0.15f, currentPosition.z - 0.02f);
    } 
}

internal enum PanelType
{
    Home = 0,
    HeartFrequency = 1,
    BreathFrequency = 2,
    Saturation = 3,
    BloodPressure = 4,
    Values = 5
}

internal class PanelWrapper
{
    public GameObject Panel { get; set; }

    public  PanelType PanelType { get; set; }
}