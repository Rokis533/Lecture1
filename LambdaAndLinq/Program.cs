using System;

namespace LambdaAndLinq
{
    public delegate bool Filter(Person person, int ageLimit);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Test1", 17));
            people.Add(new Person("Test2", 24));
            people.Add(new Person("Test3", 82));
            people.Add(new Person("Test4", 10));
            people.Add(new Person("Test5", 65));
            people.Add(new Person("Test6", 24));
            people.Add(new Person("Test7", 67));
            people.Add(new Person("Test8", 39));

            //DisplayPeople("Children", people, IsChild);
            //("Adult", people, IsAdult);
            //DisplayPeople("Senior", people, IsSenior);


            Func<int, int, int> Multiply = (int x, int y) => x * y;

            int multipl = Multiply(3, 5);


            DisplayPeople("Children", people, (person, ageLimit) => person.Age < ageLimit);

            List<Person> personFiltered = people.Where(x => x.Age > 18).ToList(); // in A returns A

            List<int> personTransformed = people.Select(x => { Console.WriteLine(x.Age); return x.Age; }).ToList(); // in A return B


            List<Person> personOrdered = people.OrderBy(x => x.Name).ThenBy(x => x.Age).ToList();

            var personMulti = people.Where(x => x.Age > 18)
                .OrderBy(x => x.Age)
                .Select(x => x.Name)
                .First();



        }


        static void DisplayPeople(string title, List<Person> people, Filter filter)
        {
            Console.WriteLine(title);

            foreach (Person person in people)
            {
                if (filter(person, 18))
                {
                    Console.WriteLine($"  {person.Name}");
                }
            }
        }
        static bool IsChild(Person person)
        {
            return person.Age < 18;
        }
        static bool IsAdult(Person person)
        {
            return person.Age >= 18 && person.Age < 65;
        }
        static bool IsSenior(Person person)
        {
            return person.Age >= 65;
        }
    }
}
