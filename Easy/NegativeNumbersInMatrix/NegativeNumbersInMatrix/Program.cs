using NegativeNumbersInMatrix.Classes;
using System;

namespace NegativeNumbersInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] a = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, -6 },
                new int[] { 11, 22 }
            };

            Console.WriteLine(MyNegativeNumbersInMatrix.CountNegatives(a));
        }
    }
}
