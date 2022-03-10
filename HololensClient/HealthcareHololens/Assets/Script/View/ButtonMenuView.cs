using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ButtonMenuView : BaseApplicationPanel
{
    private PanelWrapper[] panels;

    async void Start()
    {
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

        await this.SelectPanelAsync(PanelType.Home, false);
    }

    internal async void UpdateSelectedPanel(PanelType selectedPanel)
    {
        await this.SelectPanelAsync(selectedPanel, false);
    }

    private async Task SelectPanelAsync(PanelType selectedPanel, bool notifyServer = true)
    {
        foreach (var panel in panels)
        {
            if (panel.PanelType == selectedPanel)
            {
                panel.Panel.transform.position = GetCurrentPosition();

            }

            panel.Panel.SetActive(panel.PanelType == selectedPanel);
        }

        if (notifyServer)
        {
            await App.Controller.PersistSelectedPanel(selectedPanel);
        }
        SensorValuesPanel = GameObject.Find("SensorValuesPanel");
        SensorValuesPanel.gameObject.SetActive(false);

        PatientPanel = GameObject.Find("PatientPanel");
    }

    public void OnClickHomeButton()
    {
        Debug.Log("Home button has been pressed!");

        this.SelectPanelAsync(PanelType.Home, true);
    }

    public void OnClickHeartFrequencyButton()
    {
        Debug.Log("Heart frequency button has been pressed!");

        this.SelectPanelAsync(PanelType.HeartFrequency);
    }

    public void OnClickBreathFrequencyButton()
    {
        Debug.Log("Breath frequency button has been pressed!");

        this.SelectPanelAsync(PanelType.BreathFrequency);
    }

    public void OnClickSaturationButton()
    {
        Debug.Log("Saturation button has been pressed!");

        this.SelectPanelAsync(PanelType.Saturation);
    }

    public void OnClickBloodPressureButton()
    {
        Debug.Log("Blood Pressure button has been pressed!");

        this.SelectPanelAsync(PanelType.BloodPressure);
    }

    public void OnClickValuesButton()
    {
        Debug.Log("Values button has been pressed!");

        this.SelectPanelAsync(PanelType.Values);
    }

    public void OnClickCloseButton()
    {
        Debug.Log("Close button has been pressed!");
        App.Close();
    }

    private Vector3 GetCurrentPositionMonitor()
    {
        Vector3 currentPosition = this.transform.position;
        return new Vector3(currentPosition.x + 0.15f, currentPosition.y + 0.15f, currentPosition.z - 0.02f);
    }

    private Vector3 GetCurrentPositionPatient()
    {
        Vector3 currentPosition = this.transform.position;
        return new Vector3(currentPosition.x - 0.1f, currentPosition.y + 0.15f, currentPosition.z - 0.02f);
    }
}

public enum PanelType
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