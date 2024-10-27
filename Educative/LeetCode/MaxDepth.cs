using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
 
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
	public class MaxDepth
	{


		public int GetMaxDepth(TreeNode root)
		{
			return FindMaxDepth(root);

		}

		private int FindMaxDepth(TreeNode currentNode)
		{
			if (currentNode == null)
			{
				return 0;
			}
			int depth = 0;
			Tuple<TreeNode, int> top = new Tuple<TreeNode, int> ( currentNode, 1 );
			Stack< Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
			stack.Push(top);

			while (stack.Count > 0)
			{
				top= stack.Pop();
				currentNode = top.Item1;
				depth= Math.Max(depth,top.Item2);

				if (currentNode.left != null) 
				{
					stack.Push(new Tuple<TreeNode, int>(currentNode.left, top.Item2+1));
				}
				if(currentNode.right != null) 
				{
					stack.Push(new Tuple<TreeNode, int>((TreeNode)currentNode.right, top.Item2+1));
				}
			}
			return depth;
		}
	}
}
