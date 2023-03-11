using System;
using System.Collections.Generic;
using System.Text;

namespace DSProblems
{
	public class AVLNode
	{
		int Data { get; set; }
		AVLNode Left { get; set; }
		AVLNode Right { get; set; }
		public AVLNode(int data)
		{
			this.Data = data;
			this.Left = null;
			this.Right = null;
		}

	}

	public class AVLTree
	{
	}
}
