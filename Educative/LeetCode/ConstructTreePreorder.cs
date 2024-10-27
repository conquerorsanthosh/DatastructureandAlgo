using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
	public class ConstructTreePreorder
	{
		int preorderIndex = 0;
		public TreeNode BuildTree(int[] preorder, int[] inorder)
		{
			Dictionary<int, int> indexInorderMap = new Dictionary<int, int>();
			for (int k = 0; k < inorder.Length; k++)
			{
				indexInorderMap[inorder[k]] = k;
			}
			return BuildTree(preorder, inorder, indexInorderMap, 0, inorder.Length - 1);

		}

		private TreeNode BuildTree(int[] preorder, int[] inorder, Dictionary<int, int> indexMap, int start, int end)
		{
			if (start > end) return null;
			int index = indexMap[preorder[preorderIndex++]];
			TreeNode root = new TreeNode(inorder[index]);
			root.left = BuildTree(preorder, inorder, indexMap, start, index - 1);
			root.right = BuildTree(preorder, inorder, indexMap, index + 1, end);
			return root;
		}

	}
}
