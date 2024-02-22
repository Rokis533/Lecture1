namespace SwitchTopic
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 100;

			string range = number switch
			{
				50 => "50",
				100 => "100",
				_ => "Hi",
			};

			Console.WriteLine(range);

			switch (number)
			{
				case 0 or <= 50:
					Console.WriteLine("0 - 50");
					break;
				case > 50 or <= 100:
					Console.WriteLine("51 - 100");
					break;
				default:
					Console.WriteLine("Hi");
					break;
			}


			//switch (symbol)
			//{
			//	case 'F':
			//		Console.WriteLine("Hi");
			//		Console.WriteLine("Number is 0");
			//		break;
			//	case 'B':
			//		Console.WriteLine("Hi");
			//		Console.WriteLine("Number is 1");
			//		break;
			//	case 'D':
			//		Console.WriteLine("Hi");
			//		Console.WriteLine("Number is 2");
			//		break;
			//	case 'A':
			//		Console.WriteLine("Hi");
			//		Console.WriteLine("Number is 2");
			//		break;
			//	default:
			//		Console.WriteLine("Hi");
			//		Console.WriteLine("Number is other");
			//		break;
			//}









			//if (number == 0)
			//{
			//	Console.WriteLine("Number is 0");
			//}
			//else if (number == 1)
			//{
			//	Console.WriteLine("Number is 1");
			//}
			//else if (number == 2)
			//{
			//	Console.WriteLine("Number is 2");
			//}
			//else
			//{
			//	Console.WriteLine("Number is other");
			//}

		}
	}
}