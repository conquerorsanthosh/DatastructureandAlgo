using System;
using System.Collections.Generic;
using System.Text;

namespace DSProblems
{
	public class Node
	{
		public int Data { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }

		public Node(int data)
		{
			this.Data = data;
			this.Left = null;
			this.Right = null;
		}

	}

	public class BinarySearchTree
	{
		public Node Root { get; set; }

		public BinarySearchTree()
		{
			Root = null;
		}

		public bool InsertData(int data)
		{
			if (Root == null)
			{
				Root = new Node(data);
				return true;
			}
			return InsertNode(this.Root,new Node(data));
		}
		
		private bool InsertNode(Node currentNode, Node inputNode)
		{
			if (currentNode == null) return false;
			if (inputNode.Data >= currentNode.Data)
			{				
				if (InsertNode(currentNode.Right, inputNode) == false)
				{
					currentNode.Right = inputNode;
				}
				return true;
			}
			else if (inputNode.Data < currentNode.Data)
			{
				if (InsertNode(currentNode.Left, inputNode) == false)
				{
					currentNode.Left = inputNode;
					return true;
				}

			}
			return false;
		}

		public void DisplayAllTraversals() 
		{
			Console.WriteLine("InOrderTraversal");
			DisplayInorder(this.Root);
			Console.WriteLine("End");
			Console.WriteLine("PreOrderTraversal");
			DisplayPreorder(this.Root);
			Console.WriteLine("End");
			Console.WriteLine("PostOrderTraversal");
			DisplayPostorder(this.Root);
			Console.WriteLine("End");
			Console.WriteLine("PreOrderIterativel");
			DisplayPreOrderIterative();
			Console.WriteLine("End");
		}

		private void DisplayInorder(Node currentNode) 
		{
			if (currentNode == null) 
			{
				return;
			}

			DisplayInorder(currentNode.Left);
			Console.Write(currentNode.Data+" ->");
			DisplayInorder(currentNode.Right);
		}

		private void DisplayPreorder(Node currentNode)
		{
			if (currentNode == null)
			{
				return;
			}

			Console.Write(currentNode.Data + " ->");
			DisplayPreorder(currentNode.Left);
			DisplayPreorder(currentNode.Right);
		}
		private  void DisplayPreOrderIterative() 
		{
			Node currentNode = this.Root;
			Stack<Node> travStack = new Stack<Node>();
			travStack.Push(currentNode);
			while (travStack.Count != 0) 
			{
				Console.Write(currentNode.Data + "->");
				if (currentNode.Right != null) 
				{
					travStack.Push(currentNode.Right);
				}
				if (currentNode.Left != null)
				{
					currentNode = currentNode.Left;
				}
				else 
				{
					currentNode = travStack.Pop();
				}
			}
		}
		
		private void DisplayPostorder(Node currentNode)
		{
			if (currentNode == null)
			{
				return;
			}
			DisplayPostorder(currentNode.Left);
			DisplayPostorder(currentNode.Right);
			Console.Write(currentNode.Data + " ->");
		}
	
	}
}





		






