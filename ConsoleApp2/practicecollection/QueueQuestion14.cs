using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.practicecollection
{


    //: Check Whether Two Strings Are Anagrams
    internal class QueueQuestion14
    {

        static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";

            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            if (new string(arr1) == new string(arr2))
            {
                Console.WriteLine("Strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Strings are not Anagrams");
            }


        }
        }
}
