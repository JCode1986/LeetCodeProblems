﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleNumber.Classes
{
    public class MySingleNumber
    {
        /// <summary>
        /// Returns the element that does not appear twice
        /// </summary>
        /// <param name="nums">int[]</param>
        /// <returns>int</returns>
        public static int SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>();
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

            foreach (var entry in dict)
            {
                if (entry.Value == 1)
                {
                    return entry.Key;
                }
            }
            return 0;
        }
    }
}
