using RobotReturnToOrigin.Classes;
using System;
using Xunit;

namespace XUnitTestRobot
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("UD", true)]
        [InlineData("LL", false)]
        [InlineData("U", false)]
        [InlineData("LLRR", true)]
        [InlineData("UDLRLUDR", true)]
        [InlineData("LDURUDDDD", false)]
        public void Test(string moves, bool expected)
        {
            bool actual = Robot.JudgeCircle(moves);
            Assert.Equal(expected, actual);
        }
    }
}
