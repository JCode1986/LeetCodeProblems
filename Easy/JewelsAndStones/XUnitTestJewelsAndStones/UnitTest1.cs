using JewelsAndStones.Classes;
using System;
using Xunit;

namespace XUnitTestJewelsAndStones
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aA", "aAAbbbb", 3)]
        [InlineData("z", "ZZ", 0)]

        public void Test1(string stones, string jewels, int expected)
        {
            int actual = MyJewelsAndStones.NumJewelsInStones(stones, jewels);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aA", "aAAbbbb", 3)]
        [InlineData("z", "ZZ", 0)]

        public void Test2(string stones, string jewels, int expected)
        {
            int actual = MyJewelsAndStones.LinqSolution(stones, jewels);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aA", "aAAbbbb", 3)]
        [InlineData("z", "ZZ", 0)]

        public void Test3(string stones, string jewels, int expected)
        {
            int actual = MyJewelsAndStones.HashSetSolution(stones, jewels);
            Assert.Equal(expected, actual);
        }
    }
}
