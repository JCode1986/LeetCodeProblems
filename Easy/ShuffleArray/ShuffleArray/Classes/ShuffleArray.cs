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
            int[] x = new int[n];
            int[] y = new int[n];
            List<int> shuffledArray = new List<int>();

            for (int i = 0; i < n; i++)
            {
                x[i] = nums[i];
            }

            int j = 0;
            for (int i = n; i < nums.Length; i++)
            {
                y[j] = nums[i];
                j++;
            }

            for (int i = 0; i < x.Length; i++)
            {
                shuffledArray.Add(x[i]);
                shuffledArray.Add(y[i]);
            }

            return shuffledArray.ToArray();
        }
    }
}
