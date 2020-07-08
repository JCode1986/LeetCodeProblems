using MonotonicArray.Classes;
using System;
using Xunit;

namespace XUnitTestMonotonicArray
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, true)]
        [InlineData(new int[] { 1, 2, 2, 3 }, true)]
        [InlineData(new int[] { 6, 5, 4, 4 }, true)]
        [InlineData(new int[] { 1, 3, 2 }, false)]
        [InlineData(new int[] { 1, 2, 4, 5 }, true)]

        public void Test1(int[] values, bool expected)
        {

            bool actual = MyMonotonicArray.IsMonotonic(values);
            Assert.Equal(expected, actual);
        }
    }
}
