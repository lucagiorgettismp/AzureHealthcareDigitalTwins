using System;

[Serializable]
public class Message
{
    /* Temperature */
    public string temperature_sensor_name { get; set; }
    public bool temperature_alert { get; set; }
    public SensorValue temperature_sensor_value { get; set; }

    /* Blood Pressure */
    public string blood_pressure_sensor_name { get; set; }
    public bool blood_pressure_alert { get; set; }
    public SensorValue blood_pressure_sensor_value { get; set; }
    public string blood_pressure_graph_color { get; set; }

    /* Battery */
    public string battery_sensor_name { get; set; }
    public bool battery_alert { get; set; }
    public SensorValue battery_sensor_value { get; set; }

    /* Heart Frequency */
    public string heart_frequency_sensor_name { get; set; }
    public bool heart_frequency_alert { get; set; }
    public SensorValue heart_frequency_sensor_value { get; set; }
    public string heart_frequency_graph_color { get; set; }

    /* Breath Frequency */
    public string breath_frequency_sensor_name { get; set; }
    public bool breath_frequency_alert { get; set; }
    public SensorValue breath_frequency_sensor_value { get; set; }
    public string breath_frequency_graph_color { get; set; }

    /* Saturation */
    public string saturation_sensor_name { get; set; }
    public bool saturation_alert { get; set; }
    public SensorValue saturation_sensor_value { get; set; }
    public string saturation_graph_color { get; set; }

    public string device_id { get; set; }

    public int configuration_last_selected_view { get; set; }
}