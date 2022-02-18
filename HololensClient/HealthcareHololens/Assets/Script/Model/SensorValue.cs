using Newtonsoft.Json;

public class SensorValue
{
    [JsonProperty("min_value")]
    public double MinValue { get; set; }

    [JsonProperty("max_value")]
    public double MaxValue { get; set; }

    [JsonProperty("value")]
    public double Value { get; set; }

    [JsonProperty("unit")]
    public string Unit { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}
