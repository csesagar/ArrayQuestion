using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion1
    {
        static void Main(string[] args)
        {

            //Find the first element without removing it

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count());


        }
    }
}
