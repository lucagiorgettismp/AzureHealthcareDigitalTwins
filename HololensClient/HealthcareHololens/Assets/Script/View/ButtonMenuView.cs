using UnityEngine;

public class ButtonMenuView : MonoBehaviour
{
    GameObject VitalSignsMonitorPanel;
    GameObject HeartFrequencyPanel;
    GameObject BreathFrequencyPanel;
    GameObject SaturationPanel;
    GameObject BloodPressurePanel;

    void Start()
    {
        VitalSignsMonitorPanel = GameObject.Find("VitalSignsMonitorPanel");
        HeartFrequencyPanel = GameObject.Find("HeartFrequencyPanel");
        HeartFrequencyPanel.gameObject.SetActive(false);
        //BreathFrequencyPanel = GameObject.Find("BreathFrequencyPanel");
        //SaturationPanel = GameObject.Find("SaturationPanel");
        //BloodPressurePanel = GameObject.Find("BloodPressurePanel");
    }

    public void OnClickHomeButton()
    {
        Debug.Log("Home button has been pressed!");
        VitalSignsMonitorPanel.gameObject.SetActive(true);

        HeartFrequencyPanel.gameObject.SetActive(false);
    }

    public void OnClickHeartFrequencyButton()
    {
        Debug.Log("Heart frequency button has been pressed!");
        HideMainMonitor();
        HeartFrequencyPanel.gameObject.SetActive(true);
    }  
    
    public void OnClickBreathFrequencyButton()
    {
        Debug.Log("Breath frequency button has been pressed!");
        HideMainMonitor();
    }  
    
    public void OnClickSaturationButton()
    {
        Debug.Log("Saturation button has been pressed!");
        HideMainMonitor();
    }    
    
    public void OnClickBloodPressureButton()
    {
        Debug.Log("Blood Pressure button has been pressed!");
        HideMainMonitor();
    }    
    
    public void OnClickValuesButton()
    {
        Debug.Log("Values button has been pressed!");
        HideMainMonitor();
    }

    private void HideMainMonitor()
    {
        VitalSignsMonitorPanel.gameObject.SetActive(false);
    }
}
