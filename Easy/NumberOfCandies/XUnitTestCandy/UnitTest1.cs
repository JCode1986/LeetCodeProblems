using KidsWithGreatestNumberOfCandies.Classes;
using System;
using Xunit;

namespace XUnitTestCandy
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 5, 1, 3 }, 3, new bool[] { true, true, true, false, true })]
        [InlineData(new int[] { 4, 2, 1, 1, 2 }, 1, new bool[] { true, false, false, false, false })]
        [InlineData(new int[] { 12, 1, 12 }, 10, new bool[] { true, false, true })]

        public void ReturnsCorrectNumberOfEvenNumberedDigits(int[] numbers, int value, bool[] expected)
        {
            bool[] actual = MyKidsWithCandies.KidsWithCandies(numbers, value);
            Assert.Equal(expected, actual);
        }
    }
}
