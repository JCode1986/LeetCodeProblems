using System;
using System.Collections.Generic;
using System.Text;

namespace KidsWithGreatestNumberOfCandies.Classes
{
    public class MyKidsWithCandies
    {
        /// <summary>
        /// Returns an array of booleans of which kids can have the greatest number of candies
        /// </summary>
        /// <param name="candies">int[]</param>
        /// <param name="extraCandies">int</param>
        /// <returns>bool[]</returns>
        public static bool[] KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];
            int greatest = 0;

            //get kid with highest amount of candies, and set greatest variable
            foreach (int candy in candies)
            {
                if (candy > greatest)
                {
                    greatest = candy;
                }
            }

            //if kids with candies with extra candies is greater than or equal to greatest,
            //add true to result array. Otherwise add false.
            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = candies[i] + extraCandies >= greatest ? true : false;
            }
            return result;
        }
    }
}
