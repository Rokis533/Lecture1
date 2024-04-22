using JWTProject.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace JWTProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {

        public TestController()
        {
        }

        [HttpGet("OnlyUser")]
        [Authorize(Roles = "User")]
        public ActionResult OnlyUser()
        {
            return Ok("test ok");
        }

        [HttpGet("AdminAndUser")]
        [Authorize(Roles = "Admin, User")]
        public ActionResult AdminAndUser()
        {
            //deserializing
            return Ok("test ok");
        }
        [HttpGet("OnlyAdmin")]
        [Authorize(Roles = "Admin")]
        public ActionResult OnlyAdmin()
        {
            //deserializing
            return Ok("test ok");
        }
    }
}
