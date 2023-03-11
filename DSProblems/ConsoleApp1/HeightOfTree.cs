using System;
using System.Collections.Generic;
using System.Text;

namespace DSProblems
{
	public class HeightOfTree
	{
		Node root;
		public HeightOfTree(Node root) 
		{
			this.root = root;
		}

		public int ComputeHeightOfNode(Node node) 
		{
			return GetMeHeightOfNode(node);
			
		}

		public int ComputeHeightOfTree() 
		{
			return GetMeHeightOfNode(root);
		}

		public int GetMeHeightOfNode(Node root) 
		{
			if (root == null) return 0;
			int hLeftTree = GetMeHeightOfNode(root?.Left);
			int hRightTree = GetMeHeightOfNode(root?.Right);
			return Math.Max(hRightTree,hLeftTree)+1;
		}
	}
}
