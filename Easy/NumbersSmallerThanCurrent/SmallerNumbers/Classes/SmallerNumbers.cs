using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallerNumbers.Classes
{
    public class MySmallerNumbers
    {
        /// <summary>
        /// Returns an array that contains how many numbers are smaller than the current number
        /// </summary>
        /// <param name="nums">int[]</param>
        /// <returns>int[]</returns>
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            //Instantiate dictionary
            Dictionary<int, int> Dict = new Dictionary<int, int>();

            //array which is going to store how many numbers are smaller than the current number
            int[] result = new int[nums.Length];

            //sort array
            int[] sortedNums = nums.OrderBy(x => x).ToArray();

            //iterate through sorted nums array
            //if dictionary does not contain element, add to dictionary
            //Add the element as the key, and index as the value
            for (int i = 0; i < nums.Length; i++)
            {
                if (!Dict.ContainsKey(sortedNums[i]))
                {
                    Dict.Add(sortedNums[i], i);
                }
            }

            //iterate through array passed in method
            //place all the values (index) from the dictionary to result array
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = Dict[nums[i]];
            }

            //return array with count of all smaller numbers than the current (n)
            return result;
        }

        /// <summary>
        /// LINQ solution to LeetCode problem
        /// </summary>
        /// <param name="nums">int[]</param>
        /// <returns>int[]</returns>
        public static int[] LinqSolution(int[] nums)
        {
            return nums.Select(x => (nums.Where(i => i < x).Count())).ToArray();
        }
    }
}
