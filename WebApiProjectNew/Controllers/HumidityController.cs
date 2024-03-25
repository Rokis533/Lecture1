using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiProjectNew.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HumidityController : ControllerBase
    {
        [HttpGet]
        [Route("/GetMyHumidity")]
        public int Get()
        {
            return 0;
        }
    }
}
