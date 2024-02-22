using ObjectsTopic.Models;

namespace ObjectsTopic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //we are filling the form about person but he has to add his birthday later or can leave it empty

            Person person = new Person("Rokas", "Male");

            Console.WriteLine(person.Name);
            person.Name = null;
        }
    }
}
