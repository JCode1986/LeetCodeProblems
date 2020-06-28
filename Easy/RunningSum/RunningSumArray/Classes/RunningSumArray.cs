using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunningSumArray.Classes
{
    public class MyRunningSumArray
    {
        /// <summary>
        /// Creates a new array and returns a running sum
        /// </summary>
        /// <param name="nums">array</param>
        /// <returns>array</returns>
        public static int[] RunningSum(int[] nums)
        {
            int runningSum = 0;
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                runningSum += nums[i];
                result[i] = runningSum; 
            }
            return result;
        }

        /// <summary>
        /// Mutates array and returns with running sum
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] MutateArrayRunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            { 
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
