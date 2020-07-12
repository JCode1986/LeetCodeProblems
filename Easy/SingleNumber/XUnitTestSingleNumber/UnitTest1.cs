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
        public void TestOne(int[] numbers, int expected)
        {
            int actual = MySingleNumber.SingleNumber(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
