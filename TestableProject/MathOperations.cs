using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableProject
{
    public class MathOperations
    {
        public int Sum(int a, int b)
        {
            //if (a == int.MaxValue || b == int.MaxValue || a == int.MinValue || b == int.MinValue)
            //{
            //    throw new OverflowException();
            //}
            return a + b;


        }
    }
}
