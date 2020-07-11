using System;
using System.Collections.Generic;
using System.Text;

namespace IntersectionLinkedLists.Classes
{
    public class MyIntersectionLinkedLists
    {
        /// <summary>
        /// Returns intersecting node from 2 linked lists utilizing a dictionary
        /// </summary>
        /// <param name="headA">node</param>
        /// <param name="headB">node</param>
        /// <returns>node</returns>
        public static LinkedListNode<int> GetIntersectionNodeDictionary(LinkedListNode<int> headA, LinkedListNode<int> headB)
        {

            if (headA == null || headB == null) return null;
            if (headA == headB) return headA;

            var dict = new Dictionary<LinkedListNode<int>, LinkedListNode<int>>();

            while (headA != null)
            {
                dict[headA] = headA.Next;
                headA = headA.Next;
            }

            while (headB != null)
            {
                if (dict.ContainsKey(headB) && dict[headB] == headB.Next)
                {
                    if (dict[headB] == headB.Next)
                    {
                        return headB;
                    }
                }
                headB = headB.Next;
            }

            return null;
        }
    }
}
