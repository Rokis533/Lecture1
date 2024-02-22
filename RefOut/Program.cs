namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int retry;

            bool isValid = Login(out retry);

            if (isValid)
            {
                Console.WriteLine("Nice, it took " + retry + " retries");
            }
            else
            {
                Console.WriteLine("Fail, it took " + retry + " retries");
            }
        }

        static bool Login(out int retry)
        {
            retry = 0;
            bool isValid = false;
            do
            {
                Console.WriteLine("Enter Password");
                string input = Console.ReadLine();
                if (input == "goodday")
                {
                    isValid = true;
                }
                else
                {
                    retry++;
                }

            } while (!isValid && retry <= 3);

            return isValid;
        }




        static void GetDimention(out int width, out int height)
        {
            width = 1980;
            height = 1420;
        }



        static bool TryToMultiply(int a, int b, out int result)
        {
            result = a * b;


            if (result == 0)
            {
                return false;
            }

            return true;
        }

        static void AddNameLenght(ref int x, ref string name)
        {
            x += name.Length;
            name = "Antanas";
        }

        static void AddTen(ref int x)
        {
            x += 10;
        }


    }
}