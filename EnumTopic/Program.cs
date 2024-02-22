
namespace EnumTopic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select day:");

            foreach (var item in Enum.GetValues(typeof(Permition)))
            {
                Console.WriteLine((int)item + ". " + item);
            }

            WeekDays day = (WeekDays)int.Parse(Console.ReadLine());

            string name = "Friday";

            Enum.TryParse(name, out WeekDays result);

            switch (result)
            {
                case WeekDays.Monday:
                    break;
                case WeekDays.Tuesday:
                    break;
                case WeekDays.Wednesday:
                    break;
                case WeekDays.Thursday:
                    break;
                case WeekDays.Friday:
                    break;
                case WeekDays.Saturday:
                    break;

            }
        }
    }
}
