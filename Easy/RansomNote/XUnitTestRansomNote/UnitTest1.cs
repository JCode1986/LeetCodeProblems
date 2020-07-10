using RansomNote.Classes;
using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace XUnitTestRansomNote
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aba", true)]
        [InlineData("this is the ransom note", "this is not the ransom note", true)]
        [InlineData("I need a letter z", "sorry, we dont have that letter here", false)]
        public void Test1(string ransomNote, string magazine, bool expected)
        {
            bool actual = MyRansomNote.CanConstruct(ransomNote, magazine);
            Assert.Equal(expected, actual);
        }
    }
}
