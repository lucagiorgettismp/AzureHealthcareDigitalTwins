using Assets.Script.Utils;
using Assets.Script.View.Panels;
using TMPro;
using UnityEngine;

public class SaturationPanel : BaseLineChartSensorPanel
{
    private TextMeshPro _saturationValue;
    private TextMeshPro _saturationSensorName;
    private TextMeshPro _saturationSymbol;
    private GameObject _saturationAlert;
    private WindowGraph _saturationGraph;

    public override void InitializeComponent()
    {
        /* Datetime components */
        this._date = GameObject.Find("DetailSaturationDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailSaturationHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._saturationValue = GameObject.Find("DetailSaturationValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailSaturationBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._saturationSymbol = GameObject.Find("DetailSaturationSymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailSaturationBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._saturationSensorName = GameObject.Find("DetailSaturationSensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailSaturationBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._saturationAlert = GameObject.Find("DetailSaturationAlert");
        this._saturationAlert.GetComponent<Renderer>().material = _whiteColor;

        this._batteryAlert = GameObject.Find("DetailSaturationBatteryAlert");
        this._batteryAlert.GetComponent<Renderer>().material = _whiteColor;

        /* Line chart components */
        this._saturationGraph = GameObject.Find("DetailSaturationLineChart").GetComponent<WindowGraph>();
    }

    public override void UpdateSensorSymbols(Message message)
    {
        this._saturationSymbol.text = message.saturation_sensor_value.unit;
    }

    public override void UpdateSensorValues(Message message)
    {
        this._saturationValue.text = message.saturation_sensor_value.value.ToString();
    }

    public override void UpdateSensorNames(Message message)
    {
        this._saturationSensorName.text = message.saturation_sensor_name;
    }

    public override void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._saturationAlert, message.saturation_alarm);
    }

    public override void UpdateLineCharts(Message message)
    {
        float yAxisMin = (float)message.saturation_sensor_value.min_value;
        float yAxisMax = (float)message.saturation_sensor_value.max_value;
        float value = (float)message.saturation_sensor_value.value;

        string graphColor = (string)message.saturation_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor);

        this._saturationGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}
