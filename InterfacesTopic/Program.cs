namespace InterfacesTopic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var comparerPerson = new PersonComparer();
            List<Person> list = new List<Person>() {
                new Person() { Name = "Rokas", Age = 18 },
                new Person() { Name = "Rokas1", Age = 88 },
                new Person() { Name = "Rokas2", Age = 14 },
                new Person() { Name = "Rokas3", Age = 32 },
            };

            list.Sort(comparerPerson);

            list.ForEach(person => { Console.WriteLine(person); });
        }
    }
}
