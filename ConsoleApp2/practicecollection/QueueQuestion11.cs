using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    //Check whether a string is a palindrome using a stack
    internal class QueueQuestion11
    {
        static void Main(string[] args)
        {
            string input = "madam";
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                stack.Push(ch);
            }

            string reversed = "";

            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            Console.WriteLine(input == reversed
                ? "Palindrome"
                : "Not Palindrome");
        }
        }
}
