using UnityEngine;

public class ButtonMenuView : BaseApplicationPanel
{
    GameObject VitalSignsMonitorPanel;
    GameObject HeartFrequencyPanel;
    GameObject BreathFrequencyPanel;
    GameObject SaturationPanel;
    GameObject BloodPressurePanel;
    GameObject SensorValuesPanel;
    GameObject PatientPanel;

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

        PatientPanel = GameObject.Find("PatientPanel");
    }

    public void OnClickHomeButton()
    {
        Debug.Log("Home button has been pressed!");

        VitalSignsMonitorPanel.gameObject.SetActive(true);
        VitalSignsMonitorPanel.transform.position = GetCurrentPositionMonitor();
        PatientPanel.transform.position = GetCurrentPositionPatient();

        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }

    public void OnClickHeartFrequencyButton()
    {
        Debug.Log("Heart frequency button has been pressed!");

        HeartFrequencyPanel.gameObject.SetActive(true);
        HeartFrequencyPanel.transform.position = GetCurrentPositionMonitor();
        PatientPanel.transform.position = GetCurrentPositionPatient();

        VitalSignsMonitorPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }  
    
    public void OnClickBreathFrequencyButton()
    {
        Debug.Log("Breath frequency button has been pressed!");

        BreathFrequencyPanel.gameObject.SetActive(true);
        BreathFrequencyPanel.transform.position = GetCurrentPositionMonitor();
        PatientPanel.transform.position = GetCurrentPositionPatient();

        VitalSignsMonitorPanel.gameObject.SetActive(false);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false); 
        SensorValuesPanel.gameObject.SetActive(false);
    }  
    
    public void OnClickSaturationButton()
    {
        Debug.Log("Saturation button has been pressed!");

        SaturationPanel.gameObject.SetActive(true);
        SaturationPanel.transform.position = GetCurrentPositionMonitor();
        PatientPanel.transform.position = GetCurrentPositionPatient();

        VitalSignsMonitorPanel.gameObject.SetActive(false);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }    
    
    public void OnClickBloodPressureButton()
    {
        Debug.Log("Blood Pressure button has been pressed!");

        BloodPressurePanel.gameObject.SetActive(true);
        BloodPressurePanel.transform.position = GetCurrentPositionMonitor(); 
        PatientPanel.transform.position = GetCurrentPositionPatient();

        VitalSignsMonitorPanel.gameObject.SetActive(false);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
        SensorValuesPanel.gameObject.SetActive(false);
    }    
    
    public void OnClickValuesButton()
    {
        Debug.Log("Values button has been pressed!");

        SensorValuesPanel.gameObject.SetActive(true);
        SensorValuesPanel.transform.position = GetCurrentPositionMonitor();
        PatientPanel.transform.position = GetCurrentPositionPatient();

        VitalSignsMonitorPanel.gameObject.SetActive(false);
        BloodPressurePanel.gameObject.SetActive(false);
        HeartFrequencyPanel.gameObject.SetActive(false);
        BreathFrequencyPanel.gameObject.SetActive(false);
        SaturationPanel.gameObject.SetActive(false);
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
