using NegativeNumbersInMatrix.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestNegtaiveNumbersInMatrix
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            int[][] a = new int[][]
            {
                new int[] { 4, 3, 2,-1 },
                new int[] { 3,2,1,-1 },
                new int[] { 1, 1, -1, -2 },
                new int[] { -1, -1, -2, -3 }
            };

            int[][] b = new int[][]
            {
                new int[] { 3, 2 },
                new int[] { 1, 0 },
            };

            int[][] c = new int[][]
            {
                new int[] { 1, -1 },
                new int[] { -1, -1 },
            };

            int[][] d = { new int[] { -1 } };

            List<int[][]> storage = new List<int[][]>();
            storage.Add(a);
            storage.Add(b);
            storage.Add(c);
            storage.Add(d);

            int[] expected = new int[] { 8, 0, 3, 1 };
            int[] actual = new int[storage.Count];

            for (int i = 0; i < storage.Count; i++)
            {
                actual[i] = MyNegativeNumbersInMatrix.CountNegatives(storage[i]);
            }
            Assert.Equal(expected, actual);
        }
    }
}
