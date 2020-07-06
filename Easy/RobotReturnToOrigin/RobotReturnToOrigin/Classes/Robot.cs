using System;
using System.Collections.Generic;
using System.Text;

namespace RobotReturnToOrigin.Classes
{
    public class Robot
    {
        /// <summary>
        /// Returns a boolean whether the robots moves goes back to it's original position
        /// </summary>
        /// <param name="moves">string</param>
        /// <returns>bool</returns>
        public static bool JudgeCircle(string moves)
        {
            int vert = 0;
            int horiz = 0;

            foreach (char move in moves)
            {
                if (move == 'U') vert++;
                if (move == 'D') vert--;
                if (move == 'L') horiz++;
                if (move == 'R') horiz--;
            }
            return vert == 0 && horiz == 0;
        }
    }
}
