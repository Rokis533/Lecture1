namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print("Rokas");
            //Print(125);
            //Print(true);

            Person person = new Person()
            {
                Name = "Rokas",
                Age = 18,
                Id = 1,
            };

            SportLeague<BasketballTeam> basketballLeague = new SportLeague<BasketballTeam>();
            SportLeague<TenisTeam> tenisLeague = new SportLeague<TenisTeam>();

            basketballLeague.AddTeam(new BasketballTeam() { Name = "Žalgiris" });
            basketballLeague.AddTeam(new BasketballTeam() { Name = "Rytas" });

            tenisLeague.AddTeam(new TenisTeam() { Name = "Rytas" });

            SportLeague2 basketballLeague2 = new SportLeague2();

            basketballLeague2.AddTeam(new BasketballTeam() { Name = "Žalgiris" });

            SportLeague2 tebisballLeague2 = new SportLeague2();


            string text = "";
            Console.WriteLine(basketballLeague);


            //Print(person);

            //var repository = new Repository<string>();

            //repository.AddItem("Rokas");
            //repository.AddItem("Jonas");
            //repository.AddItem("Rimas");
            //repository.AddItem("John");

            //if (repository.Contains("John"))
            //{
            //    Console.WriteLine("Yes it has John");
            //}
            //repository.RemoveItem("John");

            //repository.Print();
            //repository.Shufle();
            //repository.Print();

            //string text = "1 2 3";
            //string[] strings = text.Split();

            //if (strings is [var a, var b, var c, ..])
            //    Foo(a, b, c);

            //Foo(strings[0], strings[1], strings[2]);
        }

        public static void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        public static void Foo(string a, string b, string c)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }

}
