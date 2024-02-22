namespace MethodsInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToyBox toyBox = new ToyBox();
            //toyBox.AddToy(new Toy() { Name = "Wolf", Weight = 3 });
            //toyBox.AddToy(new Toy() { Name = "Car", Weight = 10 });
            //toyBox.AddToy(new Toy() { Name = "Lego", Weight = 3 });

            //Toy toy = new Toy() { Name = "Duck", Weight = 2 };
            //toyBox.AddToy(toy);

            //toyBox.PrintNameOfToys();

            //Console.WriteLine("+-*-+*-*+-*-+*+-*+-*--+*");

            //toyBox.PrintNameOfToys(3);

            ErrorPrint errorPrint = new ErrorPrint();

            errorPrint.PrintNotification("Hello");
            errorPrint.PrintNotification("Sunny", "Information");
            errorPrint.PrintNotification("Bad Coding", "Warning", false);
            errorPrint.PrintNotification("StackOwerload", "Error", true);

            Square square = new Square();

            square.SetSide(3);
            square.PrintSides();

            Square square2 = new Square();

            square2.SetSide(2, 4);
            square2.PrintSides();

            Random random = new Random();

            random.Next();
            random.Next(1);
            random.Next(1, 9);
        }
    }
}
