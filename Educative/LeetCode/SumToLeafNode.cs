using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/*
	public class SumToLeafNode
	{
		public int totalsum = 0;
		public int SumNumbers(TreeNode root)
		{
			string current = null;
			ComputeSum(root, current);
			return totalsum;
		}

		private void ComputeSum(TreeNode currentNode, string currentDigits)
		{
			if (currentNode == null)
			{
				return;
			}
			currentDigits += currentNode.val.ToString();
			if (currentNode.left == null && currentNode.right == null)
			{
				if (int.TryParse(currentDigits, out int num))
				{
					totalsum += num;
				}
				return;
			}
			ComputeSum(currentNode.left, currentDigits);
			ComputeSum(currentNode.right, currentDigits);
		}
	}
	*/
	public class SumToLeafNode
	{
		public int? totalsum= new int?(0);
		public int SumNumbers(TreeNode root)
		{
			string current = null;
			int x= ComputeSum(root, current, totalsum)??0;
			return x;
		}

		private int? ComputeSum(TreeNode currentNode, string currentDigits, int? totalsum)
		{
			if (currentNode == null)
			{
				return totalsum;
			}
			currentDigits += currentNode.val.ToString();
			if (currentNode.left == null && currentNode.right == null)
			{
				if (int.TryParse(currentDigits, out int num))
				{
					totalsum += num;
				}
				return totalsum;
			}
			ComputeSum(currentNode.left, currentDigits, totalsum);
			ComputeSum(currentNode.right, currentDigits, totalsum);
			return totalsum;
		}
	}
}
