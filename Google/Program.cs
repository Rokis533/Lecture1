using System.Collections;

namespace Google
{
    internal class Program
    {
        //You are required to write a C# program that finds the most frequently occurring element in an array of integers. If there is more than one element that appears the most number of times, you can return any one of them.

        static void Main(string[] args)
        {
            // Answer 2
            int[] arr = { 1, 3, 2, 4, 3, 2, 1, 1, 3 };
            //how to solve?
            //What I have to use?


            //this function gets.....
            int n = Task(arr);
            Console.WriteLine(n);
        }


        /// <summary>
        /// This method accepts array of int<param name="arr">This is array of int</param>
        /// </summary>
        /// <param name="arr">This is array of int</param>
        /// <returns>Most frequently occurring element in an array of integers</returns>
        static int Task(int[] arr)
        {
            // number - how many times it's reapeated
            IDictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int item in arr)
            {
                //update
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else//creating new key 
                {
                    dictionary.Add(item, 1);
                }

            }
            int maxValue = 0;
            int maxKey = 0;

            foreach (var keyPair in dictionary)
            {
                if (keyPair.Value > maxValue)
                {
                    maxValue = keyPair.Value;
                    maxKey = keyPair.Key;
                }
            }

            return maxKey;
        }
    }
}
