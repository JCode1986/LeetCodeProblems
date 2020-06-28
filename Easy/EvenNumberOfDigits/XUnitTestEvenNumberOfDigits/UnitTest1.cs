using NumberWithEvenNumberOfDigits.Classes;
using System;
using Xunit;

namespace XUnitTestEvenNumberOfDigits
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 12, 345, 2, 6, 7896}, 2 )]
        [InlineData(new int[] { 555, 901, 482, 1771 }, 1)]
        [InlineData(new int[] { 5555, 9012, 4822, 1771 }, 4)]
        [InlineData(new int[] { 555, 901, 482, 177 }, 0)]

        public void ReturnsCorrectNumberOfEvenNumberedDigits(int[] numbers, int expected)
        {
            int actual = EvenNumberOfDigits.FindEvenNumberOfDigits(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
