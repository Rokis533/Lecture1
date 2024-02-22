using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTopic
{
    internal interface IRepository
    {
        public List<string> GetAll();
        public string Get(string name);
        public void Delete(string name);

        public void Update(string name, string value);
        public void DeleteAll();
    }
}
