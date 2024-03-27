namespace DependencyInjection.Services
{
    public interface ITestService
    {
        public Guid GetGuidFromMyService();

    }

    public class TestService : ITestService
    {
        private readonly IMyScopedService _myScopedService;
        public TestService(IMyScopedService myScopedService)
        {
            _myScopedService = myScopedService;
        }

        public Guid GetGuidFromMyService()
        {
            return _myScopedService.GetGuid();
        }


    }
}
