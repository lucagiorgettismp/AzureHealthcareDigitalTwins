namespace Assets.Script.View.Panels
{
    using UnityEngine;

    public abstract class BasePanel : MonoBehaviour
    {
        public VitalSignsMonitorView Parent { get { return FindObjectOfType<VitalSignsMonitorView>(); } }
    }
}