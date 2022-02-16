public class VitalSignsMonitorController : VitalSignsMonitorElement
{
    public void OnDataReceived(Message message) {
        App.View.UpdateView(message);
        App.HeartFrequencyView.UpdateView(message);
    }
}
    