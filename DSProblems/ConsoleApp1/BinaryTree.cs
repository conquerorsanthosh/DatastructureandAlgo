// C# program to print inorder traversal
// without recursion and stack
using System;

/* A binary tree tNode has data,
	pointer to left child
	and a pointer to right child */

class BinaryTree
{
	public tNode root;

	public class tNode
	{
		public int data;
		public tNode left, right;

		public tNode(int item)
		{
			data = item;
			left = right = null;
		}
	}
	/* Function to traverse binary tree without
	recursion and without stack */
	public void MorrisTraversal(tNode root)
	{
		tNode current, pre;

		if (root == null)
			return;

		current = root;
		while (current != null)
		{
			if (current.left == null)
			{
				Console.Write(current.data + " ");
				current = current.right;
			}
			else
			{
				/* Find the inorder
					predecessor of current
				*/
				pre = current.left;
				while (pre.right != null
					&& pre.right != current)
					pre = pre.right;

				/* Make current as right child
				of its inorder predecessor */
				if (pre.right == null)
				{
					pre.right = current;
					current = current.left;
				}

				/* Revert the changes made in
				if part to restore the original
				tree i.e., fix the right child
				of predecessor*/
				else
				{
					pre.right = null;
					Console.Write(current.data + " ");
					current = current.right;
				} /* End of if condition pre->right == NULL
				*/

			} /* End of if condition current->left == NULL*/

		} /* End of while */
	}

	// Driver code
	//public static void Main(String[] args)
	//{
	//	/* Constructed binary tree is
	//		1
	//		/ \
	//		2	 3
	//	/ \
	//	4	 5
	//	*/
	//	BinaryTree tree = new BinaryTree();
	//	tree.root = new tNode(1);
	//	tree.root.left = new tNode(2);
	//	tree.root.right = new tNode(3);
	//	tree.root.left.left = new tNode(4);
	//	tree.root.left.right = new tNode(5);

	//	tree.MorrisTraversal(tree.root);
	//}
}

// This code has been contributed
// by Arnab Kundu
