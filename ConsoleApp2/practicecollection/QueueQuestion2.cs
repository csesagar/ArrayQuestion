using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion2
    {

        //Reverse a queue using a stack
        //Push() adds an element to the top of the stack, and Pop() removes and returns the top element.  lifo for stack
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
             stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());     
            }

            Console.WriteLine(string.Join(",", queue));


        }
    }
}
