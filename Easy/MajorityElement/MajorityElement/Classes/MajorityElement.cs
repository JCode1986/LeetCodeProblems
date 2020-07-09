using System;
using System.Collections.Generic;
using System.Text;

namespace MajorityElement.Classes
{
    public class MyMajorityElement
    {
        /// <summary>
        /// Returns the element that shows up the most in an array
        /// </summary>
        /// <param name="nums">int[]</param>
        /// <returns>int</returns>
        public static int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            int result = 0;
            int counter = 0;

            foreach (int num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = +1;
                }
                else
                {
                    dict[num]++;
                }
            }

            foreach (var item in dict)
            {
                if (item.Value > counter)
                {
                    counter = item.Value;
                    result = item.Key;
                }
            }
            return result;
        }
    }
}
