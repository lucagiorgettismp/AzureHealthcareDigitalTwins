using Assets.Script.Utils;
using Assets.Script.View.Panels;
using TMPro;
using UnityEngine;

public class HeartFrequencyPanel : BaseLineChartSensorPanel
{
    private TextMeshPro _heartFrequencyValue;
    private TextMeshPro _heartFrequencySensorName;
    private TextMeshPro _heartFrequencySymbol;
    private GameObject _heartFrequencyAlert;
    private WindowGraph _heartFrequencyGraph;

    public override void InitializeComponent()
    {
        /* Datetime components */
        this._date = GameObject.Find("DetailHeartFrequencyDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailHeartFrequencyHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._heartFrequencyValue = GameObject.Find("DetailHeartFrequencyValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailHeartFrequencyBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._heartFrequencySymbol = GameObject.Find("DetailHeartFrequencySymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailHeartFrequencyBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._heartFrequencySensorName = GameObject.Find("DetailHeartFrequencySensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailHeartFrequencyBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._heartFrequencyAlert = GameObject.Find("DetailHeartFrequencyAlert");
        this._heartFrequencyAlert.GetComponent<Renderer>().material = _whiteColor;

        this._batteryAlert = GameObject.Find("DetailHeartFrequencyBatteryAlert");
        this._batteryAlert.GetComponent<Renderer>().material = _whiteColor;

        /* Line chart components */
        this._heartFrequencyGraph = GameObject.Find("DetailHeartFrequencyLineChart").GetComponent<WindowGraph>();
    }

    public override void UpdateSensorSymbols(Message message)
    {
        this._heartFrequencySymbol.text = message.heart_frequency_sensor_value.symbol;
    }

    public override void UpdateSensorValues(Message message)
    {
        this._heartFrequencyValue.text = message.heart_frequency_sensor_value.value.ToString();
    }

    public override void UpdateSensorNames(Message message)
    {
        this._heartFrequencySensorName.text = message.heart_frequency_sensor_name;
    }

    public override void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._heartFrequencyAlert, message.heart_frequency_alarm);
    }
    public override void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.heart_frequency_sensor_value.min_value;
        float yAxisMax = (float)message.heart_frequency_sensor_value.max_value;
        float value = (float)message.heart_frequency_sensor_value.value;

        string graphColor = (string)message.heart_frequency_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor);

        this._heartFrequencyGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
