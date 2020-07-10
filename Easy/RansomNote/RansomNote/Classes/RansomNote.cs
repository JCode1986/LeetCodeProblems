using System;
using System.Collections.Generic;
using System.Text;

namespace RansomNote.Classes
{
    public class MyRansomNote
    {
        /// <summary>
        /// Returns a boolean if a ransom note can be constructed from a magazine
        /// </summary>
        /// <param name="ransomNote">string</param>
        /// <param name="magazine">string</param>
        /// <returns>boolean</returns>
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char, int>();
            //Add every character as the key from magazine to dictionary
            //Value for the key will be a counter for how many times the letter appears
            foreach (char c in magazine)
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = +1;
                }
                else
                {
                    dict[c]++;
                }
            }

            //Iterate through ransom note, and decrement the value (counter) if a character is present
            //Return false, if character is not present in dictionary or counter is 0
            foreach (char c in ransomNote)
            {
                if (!dict.ContainsKey(c) || dict[c] == 0)
                {
                    return false;
                }
                else
                {
                    dict[c]--;
                }
            }
            return true;
        }
    }
}
