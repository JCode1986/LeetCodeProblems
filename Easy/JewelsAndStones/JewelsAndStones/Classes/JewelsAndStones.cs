using System;
using System.Collections.Generic;
using System.Text;

namespace JewelsAndStones.Classes
{
    public class MyJewelsAndStones
    {
        /// <summary>
        /// Returns how many stones are also jewels
        /// </summary>
        /// <param name="J"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int NumJewelsInStones(string J, string S)
        {
            int count = 0;

            foreach (char character in J)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (character == S[i])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
