using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class RotateList
	{

		public ListNode RotateRight(ListNode head, int k)
		{
			if (head == null)
				return null;

			if (k <= 0) return head;
			//find tail
			ListNode tail = head;
			int count = 1;
			while (tail.next != null)
			{
				tail = tail.next;
				count++;
			}
			k = k % count;
			if (count == 1 || k==0) 
				return head;

		
			//find the node which will will be new head and new tail;
			int steps = count - k;
			ListNode current = head;
			ListNode newHead = null;
			while (steps > 1)
			{
				steps--;
				current = current.next;

			}
			newHead = current.next;
			//set the new tail next to null;
			current.next = null;
			tail.next = head;
			return newHead;

		}
	}
	}

