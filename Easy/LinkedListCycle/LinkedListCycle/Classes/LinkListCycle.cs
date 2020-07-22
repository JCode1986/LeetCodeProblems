using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListCycle.Classes
{
    public class LinkListCycle
    {
        /// <summary>
        /// Returns a boolean whether a linklist is circular
        /// </summary>
        /// <param name="head">node</param>
        /// <returns>bool</returns>
        public static bool HasCycle(LinkedListNode<int> head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast) return true;
            }
            return false;
        }
    }
}
