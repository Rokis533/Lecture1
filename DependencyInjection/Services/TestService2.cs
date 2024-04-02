using Microsoft.AspNetCore.SignalR;

namespace DependencyInjection.Services
{
    public interface ITestService2
    {
        public Run GetRun();
    }

    public class TestService2 : ITestService2
    {
        private readonly IMyScopedService _scopedService;
        private readonly IMySingletonService _singletonService;
        private readonly IMyTransientService _transientService;
        public TestService2(IMyScopedService myScopedService, IMySingletonService mySingletonService, IMyTransientService transientService)
        {
            _scopedService = myScopedService;
            _singletonService = mySingletonService;
            _transientService = transientService;
        }

        public Run GetRun()
        {
            return new Run()
            {
                Transient = _transientService.GetGuid(),
                Scoped = _scopedService.GetGuid(),
                Singleton = _singletonService.GetGuid()
            };
        }
    }
}
