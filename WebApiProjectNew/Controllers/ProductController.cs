using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProjectNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = [];
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return products.Find(x => x.Id == id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] ProductDto value)
        {
            // Explanation of products.OrderBy(x => x.Id).LastOrDefault()?.Id ?? 0

            //
            //int newId = 0;
            //Product product1 = products.OrderBy(x => x.Id).LastOrDefault();
            //if (product1 is not null)
            //{
            //    newId = product1.Id;
            //}
            //else
            //{
            //    newId = 0;
            //}

            var product = new Product()
            {
                Id = products.OrderBy(x => x.Id).LastOrDefault()?.Id ?? 0,  // set to newId
                Name = value.Name,
                Description = value.Description,
                Category = value.Category,
            };
            products.Add(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
