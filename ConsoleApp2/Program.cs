using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class Program
    {
        //Insert elements into a queue and print them
        //FIFO
// Important methods:
//- Enqueue() – adds an element.
//- Dequeue() – removes and returns the first element.
//- Peek() – returns the first element without removing it.
//- Count – returns the number of elements.
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
          

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }
    }
}
