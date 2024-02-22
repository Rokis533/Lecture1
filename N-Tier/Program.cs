namespace N_Tier
{
    internal class Program
    {

        public static void Selection(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            bool exitRequest = false;
            Dictionary<string, int> ItemAndQuantity = new Dictionary<string, int>();
            do
            {
                string foodInput = Console.ReadLine();
                if (foodInput == "x")
                {
                    exitRequest = true;
                }
                else if (foodInput != "x")
                {
                    Console.WriteLine($"{foodInput} qty?");
                    int qty = int.Parse(Console.ReadLine());

                    ItemAndQuantity.Add(foodInput, qty);
                    //saugom i dict
                    //foodInput = Console.ReadLine();
                }


            } while (!exitRequest);
        }

        static void Main(string[] args)
        {
            var contactRepository = new ContactRepository();
            var contactManager = new ContactService(contactRepository);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add Contact\n2. View Contacts\n3. Exit");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter Email: ");
                        var email = Console.ReadLine();
                        contactManager.AddContact(name, email);
                        break;
                    case "2":
                        var contacts = contactManager.GetAllContacts();
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine($"Name: {contact.Name}, Email: {contact.Email}");
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}
