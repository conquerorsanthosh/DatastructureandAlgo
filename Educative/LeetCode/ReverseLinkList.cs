using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
			     
		}
		
	}

	public class LinkedList 
	{
		public ListNode head=null;

		public void AddNode(ListNode listNode) 
		{
			if(head == null && listNode!=null) 
			{
				head = listNode;
			}
			else 
			{
				ListNode current = head;

				while (current.next != null)
				{
					current = current.next;
				}
				current.next = listNode;

			}
	
		}
	
	
	}




	public  class ReverseLinkList
	{
		public ListNode reverseList(ListNode head)
		{
			ListNode prev = null;
			ListNode curr = head;
			while (curr != null)
			{
				ListNode nextTemp = curr.next;
				curr.next = prev;
				prev = curr;
				curr = nextTemp;
			}
			return prev;
		}
	}
}
