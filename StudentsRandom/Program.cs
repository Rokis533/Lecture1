namespace StudentsRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
        {
            "Darius Tarvydas", "Edgaras Bakšanskas", "Artūr Radzivilov", "Rimantas Gintilas",
            "Haroldas Žalgevičius", "German Paškovskij", "Vishwajit Singh", "Vidmantas Vanagas",
            "Deividas Ščepauskas", "Dovydas Juodys", "Taofeek Adebayo Adesina", "Augustas Dapkevičius",
            "Miglė Kižytė", "Paulius Matulevičius", "Gonzalo Guillermo Valencia Spoljaric",
            "Jevgenij Sobolkin", "Povilas Frišmantas"
        };
            Random rng = new Random(8);

            var duos = CreateDuos(names, rng);
            PrintList(duos);
            //Console.WriteLine(PickRandomStudent(names, rng));
        }

        static List<string> CreateDuos(List<string> originalNames, Random rng)
        {
            List<string> namesCopy = new List<string>(originalNames);
            List<string> duos = new List<string>();

            while (namesCopy.Count > 1)
            {
                string name1 = PickRandomStudent(namesCopy, rng);
                namesCopy.Remove(name1);

                string name2 = PickRandomStudent(namesCopy, rng);
                namesCopy.Remove(name2);

                duos.Add($"{name1} and {name2}");
            }

            if (namesCopy.Count == 1)
            {
                duos.Add($"{namesCopy[0]} has no pair");
            }

            return duos;
        }

        static string PickRandomStudent(List<string> names, Random rng)
        {
            int index = rng.Next(names.Count);
            return names[index];
        }

        static void PrintList(List<string> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
