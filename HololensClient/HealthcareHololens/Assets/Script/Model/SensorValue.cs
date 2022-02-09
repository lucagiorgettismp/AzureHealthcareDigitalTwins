using Newtonsoft.Json;

public class SensorValue
{
    [JsonProperty("value")]
    public double Value { get; set; }

    [JsonProperty("unit")]
    public string Unit { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}
