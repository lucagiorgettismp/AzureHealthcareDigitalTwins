using UnityEngine;

public class ButtonMenuView : BaseApplicationPanel
{
    GameObject VitalSignsMonitorPanel;
    GameObject HeartFrequencyPanel;
    GameObject BreathFrequencyPanel;
    GameObject SaturationPanel;
    GameObject BloodPressurePanel;
    GameObject SensorValuesPanel;

    void Start()
    {
        VitalSignsMonitorPanel = GameObject.Find("VitalSignsMonitorPanel");

        HeartFrequencyPanel = GameObject.Find("HeartFrequencyPanel");
        HeartFrequencyPanel.gameObject.SetActive(false);

        BreathFrequencyPanel = GameObject.Find("BreathFrequencyPanel");
        BreathFrequencyPanel.gameObject.SetActive(false);

        SaturationPanel = GameObject.Find("SaturationPanel");
        SaturationPanel.gameObject.SetActive(false);

        BloodPressurePanel = GameObject.Find("BloodPressurePanel");
        BloodPressurePanel.gameObject.SetActive(false);

        SensorValuesPanel = GameObject.Find("SensorValuesPanel");
        SensorValuesPanel.gameObject.SetActive(false);
    }

    public void OnClickHomeButton()
    {
        Debug.Log("Home button has been pressed!");

        VitalSignsMonitorPanel.gameObject.SetActive(true);

        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }

    public void OnClickHeartFrequencyButton()
    {
        Debug.Log("Heart frequency button has been pressed!");

        HideMainMonitor();
        HeartFrequencyPanel.gameObject.SetActive(true);
        BreathFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }  
    
    public void OnClickBreathFrequencyButton()
    {
        Debug.Log("Breath frequency button has been pressed!");

        HideMainMonitor();
        BreathFrequencyPanel.gameObject.SetActive(true);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false); 
        SensorValuesPanel.gameObject.SetActive(false);
    }  
    
    public void OnClickSaturationButton()
    {
        Debug.Log("Saturation button has been pressed!");

        HideMainMonitor();
        SaturationPanel.gameObject.SetActive(true);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }    
    
    public void OnClickBloodPressureButton()
    {
        Debug.Log("Blood Pressure button has been pressed!");

        HideMainMonitor();
        BloodPressurePanel.gameObject.SetActive(true);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }    
    
    public void OnClickValuesButton()
    {
        Debug.Log("Values button has been pressed!");

        HideMainMonitor();
        BloodPressurePanel.gameObject.SetActive(false);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(true);
    }

    public void OnClickCloseButton()
    {
        Debug.Log("Close button has been pressed!");
        App.Close();
    }

    private void HideMainMonitor()
    {
        VitalSignsMonitorPanel.gameObject.SetActive(false);
    }
}
