namespace AppFunctions.Model
{
    class TwinDataProperty<T>
    {

        public string Path { get; set; }

        public T Value { get; set; }

        public bool InAlarm { get; set; }

        public string Unit { get; set; }

    }
}