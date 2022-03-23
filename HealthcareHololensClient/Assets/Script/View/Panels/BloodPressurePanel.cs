using Assets.Script.Utils;
using Assets.Script.View.Panels;
using System;
using TMPro;
using UnityEngine;

public class BloodPressurePanel : BaseLineChartSensorPanel
{

    private TextMeshPro _bloodPressureValue;
    private TextMeshPro _bloodPressureSensorName;
    private TextMeshPro _bloodPressureSymbol;
    private GameObject _bloodPressureAlert;
    public WindowGraph _bloodPressureGraph;

    public override void InitializeComponent()
    {
        /* Datetime components */
        this._date = GameObject.Find("DetailBloodPressureDate").GetComponent<TextMeshPro>();
        this._hour = GameObject.Find("DetailBloodPressureHour").GetComponent<TextMeshPro>();

        /* Value components */
        this._bloodPressureValue = GameObject.Find("DetailBloodPressureValue").GetComponent<TextMeshPro>();
        this._batteryValue = GameObject.Find("DetailBloodPressureBatteryValue").GetComponent<TextMeshPro>();

        /* Symbol components */
        this._bloodPressureSymbol = GameObject.Find("DetailBloodPressureSymbol").GetComponent<TextMeshPro>();
        this._batterySymbol = GameObject.Find("DetailBloodPressureBatterySymbol").GetComponent<TextMeshPro>();

        /* Sensor name components */
        this._bloodPressureSensorName = GameObject.Find("DetailBloodPressureSensorName").GetComponent<TextMeshPro>();
        this._batterySensorName = GameObject.Find("DetailBloodPressureBatterySensorName").GetComponent<TextMeshPro>();

        /* Alert components */
        this._bloodPressureAlert = GameObject.Find("DetailBloodPressureAlert");
        this._bloodPressureAlert.GetComponent<Renderer>().material = _whiteColor;

        this._batteryAlert = GameObject.Find("DetailBloodPressureBatteryAlert");
        this._batteryAlert.GetComponent<Renderer>().material = _whiteColor;

        /* Line chart components */
        this._bloodPressureGraph = GameObject.Find("DetailBloodPressureLineChart").GetComponent<WindowGraph>();
    }

    public override void UpdateSensorSymbols(Message message)
    {
        this._bloodPressureSymbol.text = message.blood_pressure_sensor_value.symbol;
    }

    public override void UpdateSensorValues(Message message)
    {
        this._bloodPressureValue.text = message.blood_pressure_sensor_value.value.ToString();
    }

    public override void UpdateSensorNames(Message message)
    {
        this._bloodPressureSensorName.text = message.blood_pressure_sensor_name;
    }

    public override void UpdateSensorAlerts(Message message)
    {
        SetSensorAlert(this._bloodPressureAlert, message.blood_pressure_alarm);
    }

    public override void UpdateLineCharts(Message message)
    {
        float yAxisMin  = (float)message.blood_pressure_sensor_value.min_value;
        float yAxisMax  = (float)message.blood_pressure_sensor_value.max_value;
        float value     = (float)message.blood_pressure_sensor_value.value;

        string graphColor = (string) message.blood_pressure_graph_color;
        Color color = ColorUtils.GetColorByString(graphColor); 

        this._bloodPressureGraph.AddPoint(value, yAxisMin, yAxisMax, color);
    }
}