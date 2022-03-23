using Assets.Script.Utils;
using Assets.Script.View.Panels;
using TMPro;
using UnityEngine;

public class BreathFrequencyPanel : BaseLineChartSensorPanel
{
    private TextMeshPro _breathFrequencyValue;
    private TextMeshPro _breathFrequencySensorName;
    private TextMeshPro _breathFrequencySymbol;
    private GameObject _breathFrequencyAlert;

    private WindowGraph _breathFrequencyGraph;

    public override void InitializeComponent()
    {
        /* Datetime components */
        this._date = GameObject.Find("DetailBreathFrequencyDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailBreathFrequencyHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._breathFrequencyValue = GameObject.Find("DetailBreathFrequencyValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailBreathFrequencyBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._breathFrequencySymbol = GameObject.Find("DetailBreathFrequencySymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailBreathFrequencyBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._breathFrequencySensorName = GameObject.Find("DetailBreathFrequencySensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailBreathFrequencyBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._breathFrequencyAlert = GameObject.Find("DetailBreathFrequencyAlert");
        this._breathFrequencyAlert.GetComponent<Renderer>().material = _whiteColor;

        this._batteryAlert = GameObject.Find("DetailBreathFrequencyBatteryAlert");
        this._batteryAlert.GetComponent<Renderer>().material = _whiteColor;

        /* Line chart components */
        this._breathFrequencyGraph = GameObject.Find("DetailBreathFrequencyLineChart").GetComponent<WindowGraph>();
    }

    public override void UpdateSensorSymbols(Message message)
    { 
        this._breathFrequencySymbol.text = message.breath_frequency_sensor_value.symbol;
    }

    public override void UpdateSensorValues(Message message)
    {
        this._breathFrequencyValue.text = message.breath_frequency_sensor_value.value.ToString();
    }

    public override void UpdateSensorNames(Message message)
    {
        this._breathFrequencySensorName.text = message.breath_frequency_sensor_name;
    }

    public override void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._breathFrequencyAlert, message.breath_frequency_alarm);
    }

    public override void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.breath_frequency_sensor_value.min_value;
        float yAxisMax = (float)message.breath_frequency_sensor_value.max_value;
        float value = (float)message.breath_frequency_sensor_value.value;

        string graphColor = (string)message.breath_frequency_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor);

        this._breathFrequencyGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
