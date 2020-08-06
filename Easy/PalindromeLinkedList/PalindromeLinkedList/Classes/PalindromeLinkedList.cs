using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeLinkedList.Classes
{
    public class MyPalindromeLinkedList
    {
        /// <summary>
        /// Returns a boolean if a linked list is a palindrome
        /// </summary>
        /// <param name="head">node</param>
        /// <returns>boolean</returns>
        public static bool IsPalindrome(LinkedListNode<int> head)
        {
            var curr = head;
            List<int> storage = new List<int>();

            while (curr != null)
            {
                storage.Add(curr.Value);
                curr = curr.Next;
            }

            int i = storage.Count - 1;
            while (head != null)
            {
                if (head.Value != storage[i])
                {
                    return false;
                }
                head = head.Next;
                i--;
            }
            return true;
        }
    }
}
