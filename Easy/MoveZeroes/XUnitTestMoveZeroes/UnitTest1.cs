using MoveZeroes.Classes;
using System;
using Xunit;

namespace XUnitTestMoveZeroes
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 0, 1 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        public void Test(int[] numbers, int[] expected)
        {
            int[] actual = MyMoveZeroes.MoveZeroesSolution(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
