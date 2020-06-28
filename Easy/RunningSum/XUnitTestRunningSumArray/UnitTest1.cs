using RunningSumArray.Classes;
using System;
using Xunit;

namespace XUnitTestRunningSumArray
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 } )]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void ReturnsCorrectNumberOfEvenNumberedDigits(int[] numbers, int[] expected)
        {
            int[] actual = MyRunningSumArray.RunningSum(numbers);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void MutateArrayReturnsCorrectNumberOfEvenNumberedDigits(int[] numbers, int[] expected)
        {
            int[] actual = MyRunningSumArray.MutateArrayRunningSum(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
