using System;
using UniqueNumberOfOccurences.Classes;
using Xunit;

namespace XUnitTestUniqueOccurences
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1, 1, 3 }, true)]
        [InlineData(new int[] { 1, 2 }, false)]
        [InlineData(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true)]
        public void TestOne(int[] numbers, bool expected)
        {
            bool actual = MyUniqueNumberOfOccurences.UniqueOccurrences(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
