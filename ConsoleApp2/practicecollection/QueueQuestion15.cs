using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion15
    {

        static void Main(string[] args)
        {



            Dictionary<int, string> students =
        new Dictionary<int, string>();

            // Add
            students.Add(1, "Sagar");
            students.Add(2, "Rahul");
            students.Add(3, "Amit");

            // Read by key
            Console.WriteLine(students[1]); // Sagar

            // Update existing value
            students[2] = "Rohit";

            // Remove by key
            students.Remove(3);

            // Check key
            Console.WriteLine(students.ContainsKey(1)); // True

            // Check value
            Console.WriteLine(students.ContainsValue("Sagar")); // True

            // Safe lookup
            if (students.TryGetValue(2, out string? name))
            {
                Console.WriteLine(name); // Rohit
            }

            // Clear
            students.Clear();
        }
        }
}
