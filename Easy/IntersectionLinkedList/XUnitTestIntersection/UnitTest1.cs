using IntersectionLinkedLists.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestIntersection
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LinkedList<int> linkedList1 = new LinkedList<int>();
            LinkedList<int> linkedList2 = new LinkedList<int>();
            int[] values1 = new int[] { 1, 2, 3, 4 };
            int[] values2 = new int[] { 5, 3, 3, 4 };
            foreach (int value in values1) linkedList1.AddLast(value);
            foreach (int value in values2) linkedList2.AddLast(value);

            int actual = MyIntersectionLinkedLists.GetIntersectionNodeDictionary(linkedList1.First, linkedList2.First).Value;
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}
