using System;
using System.Collections.Generic;
using System.Text;

namespace NegativeNumbersInMatrix.Classes
{
    public class MyNegativeNumbersInMatrix
    {
        /// <summary>
        /// Returns how many negative numbers in a 2d Matrix
        /// </summary>
        /// <param name="grid">int[][]</param>
        /// <returns>int</returns>
        public static int CountNegatives(int[][] grid)
        {
            int counter = 0;

            foreach (int[] array in grid)
            {
                foreach (int num in array)
                {
                    if (num < 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
