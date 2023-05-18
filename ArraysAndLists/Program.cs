using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new int[] {1,2,3,4,5,6,7,8,9,10};
            var evens = new List<int>();
            var odds = new List<int>();
            foreach (int num in myArray)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                    odds.Add(num);
            }
            Console.WriteLine("Odd Numbers: ");
            foreach(int num in odds)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Even Numbers: ");
            foreach(int num in evens)
            {
                Console.WriteLine(num);
            }
        }
    }
}
