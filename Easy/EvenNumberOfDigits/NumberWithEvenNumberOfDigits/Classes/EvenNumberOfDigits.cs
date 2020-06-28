using System;
using System.Collections.Generic;
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
            for (int i = 0; i < nums.Length; i++)
            {
                if (Convert.ToString(nums[i]).Length % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
