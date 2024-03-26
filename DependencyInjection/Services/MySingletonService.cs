namespace DependencyInjection.Services
{
    public interface IMySingletonService
    {
        public Guid GetGuid();
    }



    public class MySingletonService : IMySingletonService
    {
        private readonly Guid _guid;
        public MySingletonService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid GetGuid()
        {
            return _guid;
        }
    }
}
