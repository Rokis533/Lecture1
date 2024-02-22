namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] names = { "Jonas", "Antanas" };



            ////                   [row, column]
            //string[,] matrix = new string[3, 3];

            //matrix[0, 0] = "Name";//     Name   Age   City  
            //matrix[0, 1] = "Age";
            //matrix[0, 2] = "City";

            //matrix[1, 0] = "Rokas Slaboševičius";//     Rokas  15   Kaunas
            //matrix[1, 1] = "15";
            //matrix[1, 2] = "Kaunas";

            //matrix[2, 0] = "Tomas";//    Tomas   19   Vilnius
            //matrix[2, 1] = "19";
            //matrix[2, 2] = "Vilnius";

            ////matrix:
            ////
            ////     Name   Age   City
            ////     Rokas  15    Kaunas
            ////     Tomas  19    Vilnius


            //// DO not recomend
            ////foreach (string s in matrix)
            ////{
            ////    Console.WriteLine(s);
            ////}

            //matrix[1, 0] = "Edgaras";
            //matrix[2, 0] = "Eglė";

            ////for (int i = 1; i < matrix.GetLength(0); i++) // changes the rows
            ////{
            ////    matrix[i, 0] = names[i - 1];
            ////}


            //for (int i = 0; i < matrix.GetLength(0); i++) // changes the rows
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) // changes the columns
            //    {
            //        Console.Write(matrix[i, j].PadRight(20));
            //    }
            //    Console.WriteLine();
            //}

            //The program asks you to enter the number of rows and columns. After inputting, you should create an array of the given size, the program should then ask you to enter the number/value of each element and print a matrix from the given numbers in example: Enter 2 2. Then Enter 1, 2, 2, 3

            Console.WriteLine("Enter a row");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a column");
            int column = int.Parse(Console.ReadLine());

            int[,] array = new int[row, column];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadRight(2));
                }
                Console.WriteLine();
            }














        }

    }
}
