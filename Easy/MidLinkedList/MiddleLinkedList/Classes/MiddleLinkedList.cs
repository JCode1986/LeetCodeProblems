using System;
using System.Collections.Generic;
using System.Text;

namespace MiddleLinkedList.Classes
{
    public class MyMiddleLinkedList
	{
		public static LinkedListNode<int> MiddleNode(LinkedListNode<int> head)
		{
			var fast = head;
			var slow = head;

			while (fast != null && fast.Next != null)
			{
				slow = slow.Next;
				fast = fast.Next.Next;
			}
			return slow;
		}
	}
}
