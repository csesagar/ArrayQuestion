using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion7
    {
        //Separate even and odd numbers

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
                {
                     1, 2, 3, 4, 5, 6, 7, 8
                 };

            var even = numbers.Where(x => x % 2 == 0);
            var odd = numbers.Where(x => x % 2 != 0);

            Console.WriteLine("Even: " + string.Join(", ", even));
            Console.WriteLine("Odd: " + string.Join(", ", odd));

        }
        }
}
