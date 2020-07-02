using System;
using System.Collections.Generic;
using System.Text;

namespace CityDestination.Classes
{
    public class MyCityDestination
    {
        /// <summary>
        /// Returns the desination city
        /// </summary>
        /// <param name="paths">List<List<string>></param>
        /// <returns>string</returns>
        public static string DestCity(List<List<string>> paths)
        {
            var hashSet = new HashSet<string>();

            foreach (var path in paths)
            {
                hashSet.Add(path[0]);
            }

            for (int i = paths.Count - 1; i >= 0; i--)
            {
                if (!hashSet.Contains(paths[i][1]))
                {
                    return paths[i][1];
                }
            }
            return null;
        }
    }
}
