using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class Reverse2
	{
		public ListNode ReverseBetween(ListNode head, int left, int right)
		{
			if (head == null) return head;

			ListNode current = head;
			ListNode leftTail = null;
			ListNode leftTailPrev = null;
			ListNode rightTail = null;
			ListNode rightTailNext = null;
			bool leftFound = false;
			int count = 1;
			while (current != null)
			{
				if (count == left && !leftFound)
				{
					leftTail = current;
					leftFound = true;
				}
				if (count == right)
				{
					rightTail = current;
					rightTailNext = current.next;
					break;
				}

				if (!leftFound)
				{
					leftTailPrev = current;
				}

				current = current.next;
				count++;
			}

			Tuple<ListNode, ListNode> reversed = ReverseStartToEnd(leftTail, rightTail, left, right);

			if (leftTailPrev != null)
			{
				leftTailPrev.next = reversed.Item1;
				reversed.Item2.next = rightTailNext;
				return head;
			}
			else
			{
				rightTailNext.next = reversed.Item2;
				return reversed.Item1;

			}


		}

		private Tuple<ListNode, ListNode> ReverseStartToEnd(ListNode start, ListNode end, int left, int right)
		{
			ListNode prev = null;
			ListNode current = start;
			ListNode nextNnode = null;

			while (left <=right)
			{
				left++;
				nextNnode = current.next;
				current.next = prev;
				prev = current;
				current = nextNnode;

			}
			Tuple<ListNode, ListNode> reversed = new Tuple<ListNode, ListNode>(prev , start);
			return reversed;
		}

		public ListNode Reverse(ListNode head) 
		{
			ListNode current = head;
			ListNode prev = null;
			ListNode nextNode = null;

			if (head == null) return head;

			while (current!= null)
			{
				nextNode = current.next;
				current.next = prev;
				prev = current;
				current = nextNode;						
			}
			return prev;
	
		}
	}
}
