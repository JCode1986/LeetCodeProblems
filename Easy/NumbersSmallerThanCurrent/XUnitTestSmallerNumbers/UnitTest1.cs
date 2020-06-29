using SmallerNumbers.Classes;
using System;
using Xunit;

namespace XUnitTestSmallerNumbers
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 8, 1, 2, 2, 3 }, new int[] { 4, 0, 1, 1, 3 })]
        [InlineData(new int[] { 6, 5, 4, 8 }, new int[] { 2, 1, 0, 3 })]
        [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { 0, 0, 0, 0 })]
        public void ReturnsCorrectNumberOfEvenNumberedDigits(int[] numbers, int[] expected)
        {
            int[] actual = MySmallerNumbers.SmallerNumbersThanCurrent(numbers);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 8, 1, 2, 2, 3 }, new int[] { 4, 0, 1, 1, 3 })]
        [InlineData(new int[] { 6, 5, 4, 8 }, new int[] { 2, 1, 0, 3 })]
        [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { 0, 0, 0, 0 })]
        public void LinqSolutionReturnsCorrectNumberOfEvenNumberedDigits(int[] numbers, int[] expected)
        {
            int[] actual = MySmallerNumbers.LinqSolution(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
