using MajorityElement.Classes;
using System;
using Xunit;

namespace XUnitTestMajorityElement
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        [InlineData(new int[] { 5, 5, 5, 2, 2, 5, 1, 1, 1, 5, 5, 2, 2 }, 5)]

        public void TestOne(int[] numbers, int expected)
        {
            int actual = MyMajorityElement.MajorityElement(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
