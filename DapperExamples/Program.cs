using DapperExamples.Models;
using DapperExamples.Repository;

namespace DapperExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=LectureProducts;Trusted_Connection=True";

            IProductRepository productService = new ProductRepository(connectionString);

            var newProductId = productService.AddProduct(new Product { Name = "New Product", Price = 10.99M, Quantity = 50 });

            var products = productService.GetAllProducts(10);

            var productsByName = productService.GetProductsByName("Lap");

            productService.UpdateProduct(new Product { Id = newProductId, Name = "Updated Product", Price = 11.99M, Quantity = 60 });

            productService.DeleteProduct(newProductId);

        }
    }
}
