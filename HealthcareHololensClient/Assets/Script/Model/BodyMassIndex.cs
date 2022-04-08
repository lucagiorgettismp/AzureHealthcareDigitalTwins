using Newtonsoft.Json;

public class BodyMassIndex
{
    [JsonProperty("unit")]
    public string Unit { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
}