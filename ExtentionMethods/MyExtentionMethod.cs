using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    internal static class MyExtentionMethod
    {
        public static bool IsLetters(this string str)
        {
            return str.All(char.IsLetter);
        }
        public static int WordCount(this string str, char splitBy)
        {
            return str.Split(splitBy).Length;
        }
    }
}
