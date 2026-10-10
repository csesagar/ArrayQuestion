using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion9
    {
        //Count the frequency of each character
        static void Main(string[] args)
        {
            string input = "hello";
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach(char ch in input)
            {
                if (frequency.ContainsKey(ch))
                {
                    frequency[ch]++;
                }
                else
                {
                    frequency[ch] = 1;
                }
                foreach (var item in frequency)
                {
                    Console.WriteLine($"{item.Key} = {item.Value} ");
                }
            }
        
        }
        }
}
