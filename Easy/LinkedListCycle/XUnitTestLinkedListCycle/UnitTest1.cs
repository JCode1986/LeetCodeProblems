using LinkedListCycle.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestLinkedListCycle
{
    public class UnitTest1
    {
        [Fact]
        public void LinkListNoCycle()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (int num in numbers)
            {
                linkedList.AddLast(num);
            }

            bool actual = LinkListCycle.HasCycle(linkedList.First);
            Assert.False(actual);
        }
    }
}
