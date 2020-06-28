using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunningSumArray.Classes
{
    public class MyRunningSumArray
    {
        /// <summary>
        /// Returns a running sum in array
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
    }
}
