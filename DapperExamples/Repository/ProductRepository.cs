using DapperExamples.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DapperExamples.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection Connection => new SqlConnection(_connectionString);

        public int AddProduct(Product product)
        {
            var sql = "INSERT INTO Product (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity);" +
                      " SELECT CAST(SCOPE_IDENTITY() as int);";

            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                var id = dbConnection.QuerySingle<int>(sql, product);
                return id;
            }
        }
        public IEnumerable<Product> GetProductsByName(string name)
        {
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Product>("GetProductsByName", new { Name = name }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<Product> GetAllProducts(int minQuantity)
        {
            var sql = "SELECT * FROM Product WHERE Quantity > @MinQuantity;";
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Product>(sql, new { MinQuantity = minQuantity }).ToList();
            }
        }

        public void UpdateProduct(Product product)
        {
            var sql = "UPDATE Product SET Name = @Name, Price = @Price, Quantity = @Quantity WHERE Id = @Id";
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(sql, product);
            }
        }

        public void DeleteProduct(int id)
        {
            var sql = "DELETE FROM Product WHERE Id = @Id";
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(sql, new { Id = id });
            }
        }
    }
}
