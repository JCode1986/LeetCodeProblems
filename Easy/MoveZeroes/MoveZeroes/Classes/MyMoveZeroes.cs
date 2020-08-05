using System;
using System.Collections.Generic;
using System.Text;

namespace MoveZeroes.Classes
{
    public class MyMoveZeroes
    {
        /// <summary>
        /// Moves all zeroes in array to the end of the array while keeping non zeroes in order
        /// </summary>
        /// <param name="nums">int[]</param>
        /// <returns>int[]</returns>
        public static int[] MoveZeroesSolution(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            temp = nums[j];
                            nums[j] = nums[i];
                            nums[i] = temp;
                            break;
                        }
                    }
                }
            }
            return nums;
        }
    }
}
