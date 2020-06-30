using ShuffleArray.Classes;
using System;
using Xunit;

namespace XUnitTestShuffleArray
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
        [InlineData(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        [InlineData(new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2, 1, 2 })]
        public void Test(int[] numbers, int value, int[] expected)
        {
            int[] actual = MyShuffleArray.Shuffle(numbers, value);
            Assert.Equal(expected, actual);
        }
    }
}
