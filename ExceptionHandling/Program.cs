namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int retry = 0;
            int index = 0;

            while (retry < 3)
            {
                try
                {

                    int[] ints = { 0, 0, 1, 2, 6 };

                    for (int i = index; i < ints.Length; i++)
                    {
                        index = i + 1;
                        int number = 10;
                        int division = number / ints[i];
                        Console.WriteLine(division);
                        break;
                    }
                    break;

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    retry++;
                    Console.WriteLine($"We had {retry} retries");
                }
            }
            Console.WriteLine("End");




        }
    }
}
