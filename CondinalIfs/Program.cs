namespace CondinalIfs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 200;
			bool isAdmin = false;

			if (number >= 50 && number <= 199)
			{
				Console.WriteLine(number);
			}
			//  is the number less when 50 and number is more when -200 or number is equal to 200 or is not Admin
			if ((number <= 50 && number >= -200) || number == 200 || !isAdmin)
			{
				Console.WriteLine(number);
			}
			bool checked1st, checked2nd, checked3rdl = true;









			if (number > 0)
			{
				Console.WriteLine("The number is positive");
				if (number >= 100)
				{
					Console.WriteLine("The number 100 or more");
				}
			}
			else if (number == 0)
			{
				Console.WriteLine("The number 0");

			}
			else if (number >= 100)
			{
				Console.WriteLine("The number 100 or more");
			}
			else if (number <= -100)
			{
				Console.WriteLine("The number -100 or less");
				if (number <= -1000 && isAdmin)
				{
					number = 0;

					Console.WriteLine("The number is set to 0");
				}
			}


			Console.WriteLine("This is the end of our application");

		}
	}
}