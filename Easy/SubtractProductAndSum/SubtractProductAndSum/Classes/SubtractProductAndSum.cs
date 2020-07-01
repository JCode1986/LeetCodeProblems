using System;
using System.Collections.Generic;
using System.Text;

namespace SubtractProductAndSum.Classes
{
    public class MySubtractProductAndSum
    {
        /// <summary>
        /// Returns an integer from product of all elements in array deducted by sum of all elements
        /// </summary>
        /// <param name="n">int</param>
        /// <returns>int</returns>
        public static int SubtractFromProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            string stringN = n.ToString();

            foreach (char c in stringN)
            {
                product *= Convert.ToInt32(c.ToString());
                sum += Convert.ToInt32(c.ToString());
            }

            return product - sum;
        }
    }
}
