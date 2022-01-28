namespace Client.AzureApi.Models
{
    public class PatientModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string Description { get; set; }

        public double BodyMassIndex { get; set; }
    }
}
