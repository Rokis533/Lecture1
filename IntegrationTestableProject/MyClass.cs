using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTestableProject
{
    public class MyClass
    {
        public virtual List<int> Numbers { get; set; }

    }
    public class MyClass2
    {
        private MyClass _myClass;
        public MyClass2(MyClass myClass)
        {
            _myClass = myClass;
        }

        public void AddNumber(int numb)
        {
            _myClass.Numbers.Add(numb);
        }
        public List<int> GetNumbers()
        {
            return _myClass.Numbers;
        }
    }
}
