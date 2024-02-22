using System.Diagnostics;

namespace DictionaryTopic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, int> ageOfPeople = new Dictionary<string, int>();

            Dictionary<string, (int, string)> ageOfPeople = new Dictionary<string, (int, string)>();

            ageOfPeople.Add("Rokas", (24, "Kaunas"));

            Console.WriteLine(ageOfPeople["Rokas"].Item1);
            Console.WriteLine(ageOfPeople["Rokas"].Item2);

            //for (int i = 0; i < 10000000; i++)
            //{
            //    ageOfPeople.Add(i.ToString(), i);
            //}

            //Console.WriteLine("---------------");
            //Stopwatch sw = Stopwatch.StartNew();

            //RemoveByValue(ageOfPeople, 9999999);

            //sw.Stop();

            //Console.WriteLine("RemoveByValue Took: \t\t".PadRight(50) + sw.Elapsed);

            //Console.WriteLine("---------------");
            //Stopwatch sw2 = Stopwatch.StartNew();

            //RemoveByValue2(ageOfPeople, 9999999);

            //sw2.Stop();

            //string key = ageOfPeople.First(x => x.Value == 12).Key;


            //Console.WriteLine("RemoveByValue(No ContainsValue()) Took: \t\t".PadRight(50) + sw2.Elapsed);
        }


        public static void PrintPeopleAndAge(Dictionary<string, int> dict)
        {

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} age is {item.Value}");
            }
        }
        public static void RemoveByValue(Dictionary<string, int> dict, int valueToRemove)
        {
            if (!dict.ContainsValue(valueToRemove))
            {
                return; //end this method, no not do anything below
            }
            foreach (var item in dict)
            {
                if (item.Value == valueToRemove)
                {
                    dict.Remove(item.Key);
                }
            }

        }
        public static void RemoveByValue2(Dictionary<string, int> dict, int valueToRemove)
        {
            foreach (var item in dict)
            {
                if (item.Value == valueToRemove)
                {
                    dict.Remove(item.Key);
                }
            }

        }
        static void MeasureTime(Func<string> method)
        {
            Stopwatch sw = Stopwatch.StartNew();

            method();

            sw.Stop();

            Console.WriteLine(method.Method.Name + " Took: \t\t" + sw.Elapsed);

        }
    }
}
