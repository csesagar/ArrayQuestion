using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{
    internal class QueueQuestion8
    {
        //    Easy interview trick:
        //- Queue = FIFO → like a line of people.         q.Enqueue(10); q.Dequeue()
        //- Stack = LIFO → like a stack of plates.         s.Push(10); s.Pop()
            static void Main(string[] args)
            {
                static bool IsValid(string s)
                {
                    Stack<char> stack = new Stack<char>();
                    foreach (char ch in s)
                    {
                        // Opening brackets
                        if (ch == '(' || ch == '{' || ch == '[')
                        {
                            stack.Push(ch);
                        }
                        else
                        {
                            // No opening bracket to match
                            if (stack.Count == 0)
                                return false;

                            char top = stack.Pop();

                            // Check matching pair
                            if (ch == ')' && top != '(')
                                return false;

                            if (ch == '}' && top != '{')
                                return false;

                            if (ch == ']' && top != '[')
                                return false;
                        }
                    }
                    // No unmatched opening brackets should remain
                    return stack.Count == 0;
                }
                static void Main()
                {
                    Console.WriteLine(IsValid("{[]}")); // True
                    Console.WriteLine(IsValid("{{]{")); // False
                    Console.WriteLine(IsValid("([{}])")); // True
                    Console.WriteLine(IsValid("(]")); // False
                }
            }
        }
    }