using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class RemoveNode
	{
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			ListNode counter = head;
			int totalNodes = 0;

			while (counter != null)
			{
				totalNodes++;
				counter = counter.next;
			}

			if (totalNodes == 1 && n == 1)
			{
				head = null;
				return head;

			}

			int npos = totalNodes - n;

			ListNode current = head;
			int pos = npos;				
			while (pos > 1)
			{
				pos--;
				current = current.next;
			}

			if (npos == 0) 
			{
				//head deletion
				head = head.next;
				return head;				
			}
			else
			{
				current.next = current.next.next;
			}
			return head;
		}


		public ListNode RemoveNthFromEndSlowFast(ListNode head, int n)
		{
			ListNode fast = head;
			ListNode slow = head;

			for (int i = 0; i < n; i++)
			{
				fast = fast.next;
			}

			if (fast == null)
			{
				head = head.next;
				return head;
			}

			while (fast.next != null)
			{
				fast = fast.next;
				slow = slow.next;
			}
			slow.next = slow.next.next;
			return head;
		}
	}


}
