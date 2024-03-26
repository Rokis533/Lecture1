namespace DependencyInjection
{
    public class Run
    {
        public Guid Scoped { get; set; }
        public Guid Singleton { get; set; }
    }


    public class RequestResult
    {
        public Run RunOne { get; set; }
        public Run RunTwo { get; set; }
    }
}
