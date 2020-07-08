using System;
using System.Collections.Generic;
using System.Text;

namespace MonotonicArray.Classes
{
    public class MyMonotonicArray
    {
        /// <summary>
        /// Returns a boolean whether an array is monotonic
        /// </summary>
        /// <param name="A">int[]</param>
        /// <returns>bool</returns>
        public static bool IsMonotonic(int[] A)
        {
            bool isInc = true;
            bool isDec = true;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[i - 1])
                {
                    isDec = false;
                }
                if (A[i] < A[i - 1])
                {
                    isInc = false;
                }
            }
            return isInc || isDec;
        }
    }
}
