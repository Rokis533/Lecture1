namespace LoopsWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty; // ""
            int sum = 0;

            do
            {
                Console.WriteLine("Enter the number to sum numbers and enter 'finish' to end");
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    sum += number;
                }

            } while (input.ToLower() != "finish");

            Console.WriteLine("Sum is " + sum);





















            //while (true)
            //{
            //    Console.Write("Enter \"exit\" to end: ");

            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "exit")
            //    {

            //        break;
            //    }

            //    Console.WriteLine("You entered: " + input);

            //}

            //Console.WriteLine("The end");

        }
    }
}