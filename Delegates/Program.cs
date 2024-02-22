namespace Delegates
{
    internal class Program
    {
        //public delegate int MathDelegate(int a, int b);

        //public delegate string NameDelegate(string text);
        //public delegate string CompanyDelegate();

        static void Main(string[] args)
        {

            var publisher = new Publisher();

            MyEventHandler eventHandler = delegate (string message)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Received message anonymous method: {message}");
                Console.ResetColor();
            };

            publisher.Handler += eventHandler;

            publisher.Handler -= eventHandler;





            var subscriber1 = new Subscriber("Subscriber 1");
            var subscriber2 = new Subscriber("Subscriber 2");

            subscriber1.Subscribe(publisher);
            subscriber2.Subscribe(publisher);



            publisher.Notify("Hello, World!");

            Console.ReadLine();



















            //var name = new NameDelegate(GetNameSurname);
            //var company = new CompanyDelegate(GetCodeAcademy);

            //Generate(GetName, GetCodeAcademy);


            //try
            //{
            //    MathDelegate AddDelegate = new MathDelegate(Add);
            //    MathDelegate SubtractDelegate = new MathDelegate(Subtract);

            //    Console.WriteLine(AddDelegate(2, 5));
            //    Console.WriteLine(SubtractDelegate(2, 5));

            //    MathDelegate MultiplicationDelegate = delegate (int x, int y)
            //    {
            //        return x * y;
            //    };
            //    Console.WriteLine("MUltiplacation");
            //    Console.WriteLine(MultiplicationDelegate(2, 5));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
        }
        //public static int Add(int x, int y, int offset = 0)
        //{
        //    return x + y + offset;
        //}


        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Subtract(int x, int y)
        //{
        //    return x - y;
        //}

        //static void Generate(NameDelegate name, CompanyDelegate getCompany)
        //{
        //    string text = name("+/**/+*");
        //    string company = getCompany();
        //    Console.WriteLine($"{text}@{company}");

        //}

        //static string GetName(string fun)
        //{
        //    return "Rokas" + fun;
        //}
        ////static string GetName()
        ////{
        ////    return "Rokas";
        ////}
        //static string GetNameSurname()
        //{
        //    return "RokasSlab";
        //}
        //static string GetAnimal()
        //{
        //    return "Rabbity*";
        //}


        //static string GetGmail()
        //{
        //    return "Gmail.com";
        //}
        //static string GetCodeAcademy()
        //{
        //    return "CodeAcademy.com";
        //}

    }
}
