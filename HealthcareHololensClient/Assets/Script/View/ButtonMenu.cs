using Assets.Script.Model;
using Assets.Script.View.Panels;
using UnityEngine;

public class ButtonMenu : BasePanel
{
    public void OnClickHomeButton()
    {
        Debug.Log("Home button has been pressed!");

        _ = this.Parent.PanelSelectionChanged(PanelType.Home);
    }

    public void OnClickHeartFrequencyButton()
    {
        Debug.Log("Heart frequency button has been pressed!");

        _ = this.Parent.PanelSelectionChanged(PanelType.HeartFrequency);
    }

    public void OnClickBreathFrequencyButton()
    {
        Debug.Log("Breath frequency button has been pressed!");

        _ = this.Parent.PanelSelectionChanged(PanelType.BreathFrequency);
    }

    public void OnClickSaturationButton()
    {
        Debug.Log("Saturation button has been pressed!");

        _ = this.Parent.PanelSelectionChanged(PanelType.Saturation);
    }

    public void OnClickBloodPressureButton()
    {
        Debug.Log("Blood Pressure button has been pressed!");

        _ = this.Parent.PanelSelectionChanged(PanelType.BloodPressure);
    }

    public void OnClickValuesButton()
    {
        Debug.Log("Values button has been pressed!");

        _ = this.Parent.PanelSelectionChanged(PanelType.Values);
    }

    public void OnClickCloseButton()
    {
        Debug.Log("Close button has been pressed!");
        this.Parent.CloseApplication();
    }
}