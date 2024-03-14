namespace Testai
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string GetInitials(string name, string surname)
        {
            return $"{name[0]}{surname[0]}";
        }

    }
    public static class MyClass
    {
        public static int AddPublic(int a, int b)
        {
            return Add(a, b);

        }

        private static int Add(int a, int b)
        {
            return a + b;

        }

    }
}
