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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), 400)]
        public ActionResult<int> Get(int numb)
        {
            if (numb <= 0)
            {
                return BadRequest("Number is below 0");
            }
            //return StatusCode(524, "I don't know what happened");
            return Ok(numb);
        }
    }
}
