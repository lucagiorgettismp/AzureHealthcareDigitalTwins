using UnityEngine;

public class VitalSignsMonitorElement : MonoBehaviour
{
    public Application App { get { return GameObject.FindObjectOfType<Application>(); } }
}

public class Application : MonoBehaviour
{
    public VitalSignsMonitorModel Model;
    public VitalSignsMonitorController Controller;
    public VitalSignsMonitorView View;
    public HeartFrequencyView HeartFrequencyView;
    public BreathFrequencyView BreathFrequencyView;
    public SaturationView SaturationView;
    public BloodPressureView BloodPressureView;
    public SensorValuesView SensorValuesView;

    void Start()
    {}
}
