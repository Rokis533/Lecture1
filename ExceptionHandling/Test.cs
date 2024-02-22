using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Test
    {
        public static void Test1()
        {
            TestError();
        }
        private static void TestError()
        {
            try
            {
                throw new BadWordException("Bad Word Used");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("Error but handled");
            }
        }
    }
}
