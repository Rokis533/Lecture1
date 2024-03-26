using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDependencyController : ControllerBase
    {
        private readonly IMyScopedService _scopedService;
        private readonly IMySingletonService _singletonService;
        private readonly ITestService _testService;
        public TestDependencyController(IMyScopedService myScopedService, IMySingletonService mySingletonService, ITestService testService)
        {
            _scopedService = myScopedService;
            _singletonService = mySingletonService;
            _testService = testService;
        }
        [HttpGet]
        public object GetServicesGuid()
        {
            //object result = new
            //{
            //    runOne = new
            //    {
            //        scoped = _scopedService.GetGuid(),
            //        singleton = _singletonService.GetGuid()
            //    },
            //    runTwo = new
            //    {
            //        scoped = _scopedService.GetGuid(),
            //        singleton = _singletonService.GetGuid()
            //    }
            //};

            RequestResult result2 = new RequestResult()
            {
                RunOne = new Run()
                {
                    Scoped = _scopedService.GetGuid(),
                    Singleton = _singletonService.GetGuid()
                },
                RunTwo = new Run()
                {
                    Scoped = _scopedService.GetGuid(),
                    Singleton = _singletonService.GetGuid()
                }
            };



            return result2;
        }
        [HttpGet("GetServicesGuidFromTestService")]
        public Guid GetServicesGuidFromTestService()
        {

            return _testService.GetGuidFromMyService();
        }


    }
}
