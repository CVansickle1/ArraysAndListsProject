using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            List<int> odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int i in myArray)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                   
                }
                else
                {
                    odds.Add(i);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Here are all the Evens in the list");
            Console.Write("( ");
            for (int i = 0; i < evens.Count; i++)
            {
                if (i < evens.Count - 1)
                {
                    Console.Write(evens[i]);
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(evens[i]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine(")");

            Console.WriteLine("Here are all the Odds in the list");
            string result;
            Console.Write("( ");
            foreach (int i in odds)
            {
                if (i < odds[odds.Count - 1])
                {
                    result = $"{i}, ";
                }
                else
                {
                    result = $"{i} ";
                }
                Console.Write(result);
            }
            Console.WriteLine(")");
        }
    }
}
