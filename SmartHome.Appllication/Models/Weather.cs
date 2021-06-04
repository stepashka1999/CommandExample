namespace SmartHome.Data.Models
{
    public class Weather
    {
        public int CurrentTemp { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }

        public override string ToString()
        {
            return $"Current temperature: {CurrentTemp}t\n"
                    + $"Min temperature: {MinTemp}t\n"
                    + $"Max temperature: {MaxTemp}t";
        }
    }
}