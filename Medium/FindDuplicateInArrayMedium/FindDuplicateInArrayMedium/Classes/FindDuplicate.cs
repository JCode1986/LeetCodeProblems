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
		public static int FindDup(int[] nums)
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

		/// <summary>
		/// Returns the single element with duplicates in array utilizing binary search
		/// </summary>
		/// <param name="nums">int[]</param>
		/// <returns>int</returns>
		public static int FindDupBinary(int[] nums)
        {
			int low = 1;
			int high = nums[nums.Length - 1];

			while (low < high)
            {
				int mid = low + (high - low) / 2;
				int count = 0;

				for (int i = 0; i < nums.Length; i++)
                {
					if (nums[i] <= mid)
                    {
						count += 1;
                    }
                }
				if (count <= mid)
                {
					low = mid + 1;
                }
                else
                {
					high = mid;
                }
            }
			return low;
        }
	}
}
