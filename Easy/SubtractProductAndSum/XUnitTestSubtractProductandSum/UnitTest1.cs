using SubtractProductAndSum.Classes;
using System;
using Xunit;

namespace XUnitTestSubtractProductandSum
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(234, 15)]
        [InlineData(4421, 21)]

        public void Test(int num, int expected)
        {
            int actual = MySubtractProductAndSum.SubtractFromProductAndSum(num);
            Assert.Equal(expected, actual);
        }
    }
}
