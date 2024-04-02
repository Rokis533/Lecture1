using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDependencyController : ControllerBase
    {

        private readonly ITestService _testService;
        private readonly ITestService2 _testService2;
        public TestDependencyController(ITestService testService, ITestService2 testService2)
        {

            _testService = testService;
            _testService2 = testService2;
        }
        [HttpGet]
        public object GetServicesGuid()
        {

            RequestResult result2 = new RequestResult();



            result2.RunOne = _testService.GetRun();
            result2.RunTwo = _testService2.GetRun();


            return result2;
        }


    }
}
