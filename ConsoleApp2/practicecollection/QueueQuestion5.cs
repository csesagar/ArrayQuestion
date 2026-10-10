using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp2.practicecollection
{
    //Remove duplicate elements from a list
    internal class QueueQuestion5
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
               {
                   1, 2, 2, 3, 4, 4, 5
                };

            List<int> unique = numbers.Distinct().ToList();

            Console.WriteLine(string.Join(", ", unique));

        }
        }
}
