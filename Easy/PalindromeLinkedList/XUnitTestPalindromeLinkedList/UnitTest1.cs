using PalindromeLinkedList.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestPalindromeLinkedList
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 2, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, false)]
        [InlineData(new int[] { 1 }, true)]
        [InlineData(new int[] { 1, 1 }, true)]
        [InlineData(new int[] { 1, 2, 1 }, true)]
        [InlineData(new int[] { 6, 4, 2, 1, 3 }, false)]
        public void Test1(int[] numbers, bool expected)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            foreach (int num in numbers)
            {
                linkedList.AddLast(num);
            }
            bool actual = MyPalindromeLinkedList.IsPalindrome(linkedList.First);
            Assert.Equal(expected, actual);
        }
    }
}
