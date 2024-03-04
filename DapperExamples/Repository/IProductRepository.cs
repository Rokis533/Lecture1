using DapperExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExamples.Repository
{
    internal interface IProductRepository
    {
        public int AddProduct(Product product);
        public IEnumerable<Product> GetProductsByName(string name);
        public IEnumerable<Product> GetAllProducts(int minQuantity);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}
