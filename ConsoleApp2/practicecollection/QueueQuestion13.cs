using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    //Find unique elements using HashSet
    internal class QueueQuestion13
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

            HashSet<int> unique = new HashSet<int>(numbers);

            foreach (int number in unique)
            {
                Console.WriteLine(number);
            }
        }
        }
}
