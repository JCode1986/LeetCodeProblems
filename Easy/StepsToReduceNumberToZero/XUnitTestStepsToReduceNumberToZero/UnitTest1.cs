using StepsToReduceNumberToZero.Classes;
using System;
using Xunit;

namespace XUnitTestStepsToReduceNumberToZero
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(14, 6)]
        [InlineData(8, 4)]
        [InlineData(123, 12)]
        public void Test(int input, int expected)
        {
            int actual = MyStepsToReduceNumberToZero.NumberOfSteps(input);
            Assert.Equal(expected, actual);
        }
    }
}
