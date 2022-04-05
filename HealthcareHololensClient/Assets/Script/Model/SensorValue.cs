using System;

[Serializable]
public class SensorValue
{
    public double min_value { get; set; }
    public double max_value { get; set; }
    public double value { get; set; }
    public string unit { get; set; }
    public string type { get; set; }
}
