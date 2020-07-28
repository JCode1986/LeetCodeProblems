using FindDuplicateInArrayMedium.Classes;
using System;
using Xunit;

namespace XUnitTestFindDuplicate
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 2, 2 }, 2)]
        [InlineData(new int[] { 3, 1, 3, 4, 2 }, 3)]
        public void TestOne(int[] numbers, int expected)
        {
            int actual = FindDuplicate.FindDup(numbers);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 2, 2 }, 2)]
        [InlineData(new int[] { 3, 1, 3, 4, 2 }, 3)]
        public void TestTwo(int[] numbers, int expected)
        {
            int actual = FindDuplicate.FindDupBinary(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
