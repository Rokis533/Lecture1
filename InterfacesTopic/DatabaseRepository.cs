using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTopic
{
    internal class DatabaseRepository : IRepository
    {
        public void Delete(string name)
        {
            Console.WriteLine("Delete");
        }

        public string Get(string name)
        {
            return name;
        }

        public List<string> GetAll()
        {
            return new List<string>();
        }

        void IRepository.DeleteAll()
        {
            throw new NotImplementedException();
        }

        void IRepository.Update(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}
