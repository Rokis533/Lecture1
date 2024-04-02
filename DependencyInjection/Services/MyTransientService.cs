namespace DependencyInjection.Services
{
    public interface IMyTransientService
    {
        public Guid GetGuid();
    }

    public class MyTransientService : IMyTransientService
    {
        private readonly Guid _guid;
        public MyTransientService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid GetGuid()
        {
            return _guid;
        }
    }
}
