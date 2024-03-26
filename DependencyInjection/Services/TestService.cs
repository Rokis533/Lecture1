namespace DependencyInjection.Services
{
    public interface ITestService
    {
        public Guid GetGuidFromMyService();

    }

    public class TestService : ITestService
    {
        private readonly Lazy<IMyScopedService> _myScopedService;
        public TestService(Lazy<IMyScopedService> myScopedService)
        {
            _myScopedService = myScopedService;
        }

        public Guid GetGuidFromMyService()
        {
            return _myScopedService.Value.GetGuid();
        }


    }
}
