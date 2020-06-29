using System;
using System.Collections.Generic;
using System.Text;

namespace ShuffleArray.Classes
{
    public class MyShuffleArray
    {
        /// <summary>
        /// Returns a new array with elements shuffled from x (first half of array) and y (second half)
        /// </summary>
        /// <param name="nums">int[]</param>
        /// <param name="n">int; array's length cut in half</param>
        /// <returns>int[]; zipped array</returns>
        public static int[] Shuffle(int[] nums, int n)
        {
            List<int> shuffledArray = new List<int>();

            for (int i = 0; i < n; i++)
            {
                shuffledArray.Add(nums[i]);
                shuffledArray.Add(nums[n + i]);
            }
            return shuffledArray.ToArray();
        }
    }
}
