namespace DependencyInjection.Services
{
    public interface IMyScopedService
    {
        public Guid GetGuid();
    }

    public class MyScopedService : IMyScopedService
    {
        private readonly Guid _guid;
        public MyScopedService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid GetGuid()
        {
            return _guid;
        }
    }
}
