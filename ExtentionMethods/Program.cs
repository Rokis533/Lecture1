using System.Reflection;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello,my,name,is,Rokas";

            bool isAlphabetic = text.IsLetters();

            int wordCount = text.WordCount(' ');
        }
    }
}
