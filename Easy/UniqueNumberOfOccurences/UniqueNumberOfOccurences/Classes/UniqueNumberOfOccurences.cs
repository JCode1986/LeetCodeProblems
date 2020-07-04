using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueNumberOfOccurences.Classes
{
    public class MyUniqueNumberOfOccurences
    {
        /// <summary>
        /// Returns a boolean whether an occurence for elements are unique
        /// </summary>
        /// <param name="arr">int[]</param>
        /// <returns>bool</returns>
        public static bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            var hash = new HashSet<int>();

            foreach (int num in arr)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 1;
                }
                else
                {
                    dict[num]++;
                }
            }

            foreach (int occurences in dict.Values)
            {
                if (hash.Contains(occurences))
                {
                    return false;
                }
                hash.Add(occurences);
            }
            return true;
        }
    }
}
