public class VitalSignsMonitorController : VitalSignsMonitorElement
{
    public void OnDataReceived(Message message) {
        App.View.UpdateView(message);
        App.HeartFrequencyView.UpdateView(message);
        App.BreathFrequencyView.UpdateView(message);
        App.SaturationView.UpdateView(message);
        App.BloodPressureView.UpdateView(message);
        App.SensorValuesView.UpdateView(message);
    }
}
    