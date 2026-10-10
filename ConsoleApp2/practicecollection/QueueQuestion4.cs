using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    //Find the largest and smallest numbers in a list
    internal class QueueQuestion4
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
              {
                    10, 50, 20, 5, 80, 30
              };

            Console.WriteLine("Maximum: " + numbers.Max());
            Console.WriteLine("Minimum: " + numbers.Min());

        }
        }
}
