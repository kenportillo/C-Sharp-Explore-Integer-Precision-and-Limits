using System;

namespace Explore_Integer_Precision_and_Limits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Quotent and Remainder Operators
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotent: {d}");
            Console.WriteLine($"remainder: {e}");

            // int minimum and maximum limits
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            // Underflow & Overflow
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            int why = min + 2;
            Console.WriteLine($"An example of overflow: {why}");

            // the answer is a very large negative number because an overflow "wraps around" from the largest possible integer value to the smallest.

        }
    }
}
