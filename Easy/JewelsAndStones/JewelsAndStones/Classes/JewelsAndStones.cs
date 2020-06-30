using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JewelsAndStones.Classes
{
    public class MyJewelsAndStones
    {
        /// <summary>
        /// Returns how many stones are also jewels
        /// </summary>
        /// <param name="J">string</param>
        /// <param name="S">string</param>
        /// <returns>int</returns>
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

        /// <summary>
        /// Linq solution
        /// </summary>
        /// <param name="J">string</param>
        /// <param name="S">string</param>
        /// <returns>int</returns>
        public static int LinqSolution(string J, string S)
        {
            return S.Count(J.Contains);
        }

        /// <summary>
        /// Hash Set Solution
        /// </summary>
        /// <param name="J">string</param>
        /// <param name="S">string</param>
        /// <returns>int</returns>
        public static int HashSetSolution(string J, string S)
        {
            if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(J))
            {
                return 0;
            }

            HashSet<char> jewels = new HashSet<char>();
            int jewelCount = 0;

            for (int i = 0; i < J.Length; i++)
            {
                jewels.Add(J[i]);
            }
            for (int i = 0; i < S.Length; i++)
            {
                if (jewels.Contains(S[i]))
                {
                    jewelCount++;
                }
            }
            return jewelCount;
        }
    }
}
