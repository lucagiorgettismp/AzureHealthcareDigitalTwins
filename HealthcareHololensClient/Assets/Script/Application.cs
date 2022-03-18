using UnityEngine;

public class BaseApplicationPanel : MonoBehaviour
{
    public Application App { get { return GameObject.FindObjectOfType<Application>(); } }
}

public class Application : MonoBehaviour
{
    public VitalSignsMonitorModel Model;
    public VitalSignsMonitorController Controller;
    public VitalSignsMonitorView VitalSignsMonitorView;
    public HeartFrequencyView HeartFrequencyView;
    public BreathFrequencyView BreathFrequencyView;
    public SaturationView SaturationView;
    public BloodPressureView BloodPressureView;
    public SensorValuesView SensorValuesView;
    public PatientView PatientView;
    public ButtonMenuView ButtonMenuView;

    public void Start()
    {}

    public void Close()
    {
        UnityEngine.Application.Quit();
    }
}