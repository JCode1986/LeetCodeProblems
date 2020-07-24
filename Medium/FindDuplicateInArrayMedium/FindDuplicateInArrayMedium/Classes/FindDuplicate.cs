using System;
using System.Collections.Generic;
using System.Text;

namespace FindDuplicateInArrayMedium.Classes
{
    public class FindDuplicate
    {
		/// <summary>
		/// Returns the single element with duplicates in array
		/// </summary>
		/// <param name="nums">int[]</param>
		/// <returns>int</returns>
		public int FindDup(int[] nums)
		{
			if (nums.Length > 1)
			{
				int slow = nums[0];
				int fast = nums[nums[0]];
				while (slow != fast)
				{
					slow = nums[slow];
					fast = nums[nums[fast]];
				}

				fast = 0;
				while (fast != slow)
				{
					fast = nums[fast];
					slow = nums[slow];
				}
				return slow;
			}
			return -1;
		}
	}
}
