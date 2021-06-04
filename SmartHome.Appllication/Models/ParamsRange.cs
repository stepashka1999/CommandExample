namespace SmartHome.Data.Models
{
    public class ParamsRange
    {
        public int MinCount { get; set;} = 0; //Coutn of parameters anyway cant be less than 0
        public int MaxCount { get; set; }
        public bool IsOutOfRange(int commandsCount)
        {
            return commandsCount > MaxCount || commandsCount < MinCount;
        }
    }
}