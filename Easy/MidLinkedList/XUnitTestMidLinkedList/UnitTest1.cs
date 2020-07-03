using MiddleLinkedList.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Xunit;

namespace XUnitTestMidLinkedList
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 4)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        public void Test1(int[] numbers, int expected)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            foreach(int num in numbers)
            {
                linkedList.AddLast(num);
            }

            int actual = MyMiddleLinkedList.MiddleNode(linkedList.First).Value;
            Assert.Equal(expected, actual);
        }
    }
}
