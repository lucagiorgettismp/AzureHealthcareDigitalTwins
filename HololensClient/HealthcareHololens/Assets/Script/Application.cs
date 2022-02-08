using UnityEngine;

public class VitalSignsMonitorElement : MonoBehaviour
{
    public Application app { get { return GameObject.FindObjectOfType<Application>(); } }
}

public class Application : MonoBehaviour
{
    public VitalSignsMonitorModel Model;
    public VitalSignsMonitorView View;
    public VitalSignsMonitorController Controller;

    void Start()
    {
        //Debug.Log("Hello " + gameObject.name);

        //Controller = new VitalSignsMonitorController();
        //View = new VitalSignsMonitorView();

        //Model = new VitalSignsMonitorModel();
        //Model.Start();
    }
}
