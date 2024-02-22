namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Enum.GetValues(WeekDays))
            {

            }


            WeekDays day = WeekDays.Friday;

            switch (day)
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
