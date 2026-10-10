using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion6
    {
        //Find the second - largest distinct number
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
             {
                 10, 50, 20, 80, 80, 30
             };

            int secondLargest = numbers
                .Distinct()
                .OrderByDescending(x => x)
                .Skip(1)
                .First();

            Console.WriteLine(secondLargest);

        }
        }
}
