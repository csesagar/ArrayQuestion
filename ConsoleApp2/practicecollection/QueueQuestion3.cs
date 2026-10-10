using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion3
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");

            int n = 5;

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();

                Console.WriteLine(current);

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }
        }
    }
