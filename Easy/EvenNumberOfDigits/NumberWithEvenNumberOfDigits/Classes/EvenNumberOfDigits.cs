using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberWithEvenNumberOfDigits.Classes
{
    public class EvenNumberOfDigits
    {
        /// <summary>
        /// Returns a count of even number digits in array
        /// </summary>
        /// <param name="nums">array</param>
        /// <returns>int</returns>
        public static int FindEvenNumberOfDigits(int[] nums)
        {
            int count = 0;
            foreach (int number in nums)
            {
                if (number.ToString().Length % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// One liner linq query solution
        /// </summary>
        /// <param name="nums">array</param>
        /// <returns>int</returns>
        public static int LinqSolution(int[] nums)
        {
            return nums.Count(x => x.ToString().Length % 2 == 0);
        }
    }
}
