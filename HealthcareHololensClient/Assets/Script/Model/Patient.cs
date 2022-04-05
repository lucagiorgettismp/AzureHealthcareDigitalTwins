using Newtonsoft.Json;

public class Patient
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("surname")]
    public string Surname { get; set; }

    [JsonProperty("gender")]
    public string Gender { get; set; }

    [JsonProperty("age")]
    public int Age { get; set; }

    [JsonProperty("height")]
    public string Height { get; set; }

    [JsonProperty("weight")]
    public string Weight { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("fiscalcode")]
    public string FiscalCode { get; set; }

    [JsonProperty("bodymassindex")]
    public BodyMassIndex BodyMassIndex { get; set; }
}
