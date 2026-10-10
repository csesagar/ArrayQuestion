using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp2.practicecollection
{
    //Find common elements between two lists
    internal class QueueQuestion12
    {
        static void Main(string[] args)
        {
            List<int> first = new List<int>
            {
                  1, 2, 3, 4, 5
            };
            List<int> second = new List<int>
                {
                    3, 4, 5, 6, 7
                };
            var common = first.Intersect(second);
            Console.WriteLine(string.Join(", ", common));
        }
        }
}
