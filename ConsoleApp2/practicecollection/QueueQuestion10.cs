using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    //Find duplicate numbers using a Dictionary
    internal class QueueQuestion10
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 2, 4, 1, 5 };

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                    frequency[number]++;
                else
                    frequency[number] = 1;
            }

            foreach (var item in frequency)
            {
                if (item.Value > 1)
                    Console.WriteLine(item.Key);
            }

        }
        }
}
