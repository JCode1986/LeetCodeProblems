using SingleNumber.Classes;
using System;
using Xunit;

namespace XUnitTestSingleNumber
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 3, 3, 4, 4, 5, 5, 420}, 420)]
        [InlineData(new int[] { 17, 12, 5, -6, 12, 4, 17, -5, 2, -3, 2, 4, 5, 16, -3, -4, 15, 15, -4, -5, -6 }, 16)]
        public void TestOne(int[] numbers, int expected)
        {
            int actual = MySingleNumber.SingleNumber(numbers);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 3, 3, 4, 4, 5, 5, 420 }, 420)]
        [InlineData(new int[] { 17, 12, 5, -6, 12, 4, 17, -5, 2, -3, 2, 4, 5, 16, -3, -4, 15, 15, -4, -5, -6 }, 16)]
        public void TestTwo(int[] numbers, int expected)
        {
            int actual = MySingleNumber.SingleNumberNoExtraSpace(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
