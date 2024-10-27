using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode 
{
	public class ReverseNodeKgroup
	{
		public ListNode ReverseKGroup(ListNode head, int k)
		{

			/*Algorithm
			1. Two pointers initialized to head
			2. Move the second pointer until its equal to k
			3. If the number of the remaining nodes is less than k, exit the algo
			4. else proceed with increamenting second pointer until it reaches k
			5. once the second pointer reaches the size of k, reverse the list.
			6. Make sure that we store the node reference for next of second and prev of first pointer.
			7. Once the reverse list is obtained connect the prev to rev head and tail to next of second.
			8. intialize the first and second to next of second , go to step 2*/

			//code
			ListNode prev = null;
			ListNode first = head;
			ListNode second = head;
			ListNode secondNext = null;
			Tuple<ListNode, ListNode> reversedList = null;
			ListNode newHead = null;
			int count = 1;

			while (second != null)
			{
				if (count == k)
				{
					//ListNode nprev = second;
					secondNext = second.next;
					reversedList = ReverseBetween(first, second,k);
					if (prev != null)
					{
						prev.next = reversedList.Item1;
						reversedList.Item2.next = secondNext;


					}
					else
					{
						reversedList.Item2.next = secondNext;
						newHead = reversedList.Item1;
					}

					count = 0;
					first = secondNext;
					second = secondNext;
					prev = reversedList.Item2;
				}
				else
				{
					second = second.next;
				}
				count++;
			}

			return newHead;

		}

		private Tuple<ListNode, ListNode> ReverseBetween(ListNode start, ListNode End,int k)
		{
			ListNode prev = null;
			ListNode current = start;
			ListNode nextNode = null;
			ListNode revTail = null;

			while (k>0)
			{
				k--;
				nextNode = current.next;
				current.next = prev;
				prev = current;
				if (revTail==null) { revTail = current; }
				current = nextNode;
			}
			return new Tuple<ListNode, ListNode>(prev, revTail);
		}
	}
}
