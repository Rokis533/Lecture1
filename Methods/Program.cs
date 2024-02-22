namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Recusion(5);


            //HelloWorld();
            //bool isUnderAge = IsOfLegalAge(1999);

            //Console.WriteLine(isUnderAge);

            //Console.WriteLine(CalculateAge(1999));
            //HelloWorld();
            //switch (0)
            //{
            //    case 0:
            //        Console.WriteLine(CalculateAge(1999));
            //        break;
            //    case 1:
            //        bool isUnderAge = IsOfLegalAge(1999);

            //        Console.WriteLine(isUnderAge);
            //        break;
            //    case 2:
            //        HelloWorld();
            //        break;
            //    case 3:
            //        PrintCat();
            //        break;
            //}
            //    int number1 = int.Parse(Console.ReadLine());
            //    int number2 = int.Parse(Console.ReadLine());

            //    int sum = Sum(number1, number2);
            //    Console.WriteLine(sum);
        }

        public static void Recusion(int number)
        {
            if (number == 0)
            {
                return;
            }
            Console.WriteLine(number);
            Recusion(number - 1);

        }

        //public static bool IsOfLegalAge(int yearOfBirth)
        //{
        //    return CalculateAge(yearOfBirth) <= 18;
        //}

        //public static int CalculateAge(int yearOfBirth)
        //{
        //    return DateTime.Now.Year - yearOfBirth;
        //}


        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        //public static void HelloWorld()
        //{
        //    Console.WriteLine("|\\---/|\r\n| o_o |\r\n \\_^_/");
        //    Console.WriteLine("Hello, World");
        //}
        //public static void PrintCat()
        //{
        //    Console.WriteLine("   |\\---/|\r\n   | ,_, |\r\n    \\_`_/-..----.\r\n ___/ `   ' ,\"\"+ \\  sk\r\n(__...'   __\\    |`.___.';\r\n  (_,...'(_,.`__)/'.....+");
        //}





    }
}