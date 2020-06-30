using System;
using System.Collections.Generic;
using System.Text;

namespace StepsToReduceNumberToZero.Classes
{
    public class MyStepsToReduceNumberToZero
    {
        /// <summary>
        /// Returns number of steps it takes to reduce a number to zero
        /// </summary>
        /// <param name="num">int</param>
        /// <returns>int</returns>
        public static int NumberOfSteps(int num)
        {
            int steps = 0;
            while (num != 0)
            {
                num = num % 2 == 0 ? num / 2 : num - 1;
                steps++;
            }
            return steps;
        }
    }
}
