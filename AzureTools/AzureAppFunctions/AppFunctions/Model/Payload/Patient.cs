using Newtonsoft.Json;

namespace AppFunctions.Model.Payload
{
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
        public double Height { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fiscal_code")]
        public string FiscalCode { get; set; }
    }
}