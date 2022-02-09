using UnityEngine;

public class VitalSignsMonitorElement : MonoBehaviour
{
    public Application App { get { return GameObject.FindObjectOfType<Application>(); } }
}

public class Application : MonoBehaviour
{
    public VitalSignsMonitorModel Model;
    public VitalSignsMonitorView View;
    public VitalSignsMonitorController Controller;

    void Start()
    {}
}
