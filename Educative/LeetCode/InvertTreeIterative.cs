using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class InvertTreeIterative
	{
		public TreeNode InvertTree(TreeNode root)
		{
			ProcessInvertTree(root);
			return root;

		}

		private void ProcessInvertTree(TreeNode current)
		{
			if (current == null)
			{
				return;
			}

			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(current);

			while (queue.Count > 0)
			{
				TreeNode node = queue.Dequeue();
				if (node.left!=null) queue.Enqueue(node.left);
				if (node.right != null) queue.Enqueue(node.right);
				string s;
				

			}
		}
	}
}
