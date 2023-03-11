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
			return InsertNode(this.Root, new Node(data));
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
			Console.WriteLine("PreOrderIterativel-Optimized");
			DisplayPreOrderIterative_Optimized();
			Console.WriteLine("End");
			Console.WriteLine("POstOrderIterativel-Optimized");
			DisplayPostOrderIterative();
			Console.WriteLine("End");
		}

		private void DisplayInorder(Node currentNode)
		{
			if (currentNode == null)
			{
				return;
			}

			DisplayInorder(currentNode.Left);
			Console.Write(currentNode.Data + " ->");
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
		private void DisplayPreOrderIterative()
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

		private void DisplayPreOrderIterative_Optimized()
		{
			Node currentNode = this.Root;
			if (currentNode == null) return;
			Stack<Node> travStack = new Stack<Node>();
			travStack.Push(currentNode);

			while (travStack.Count > 0)
			{
				currentNode = travStack.Pop();
				Console.Write(currentNode.Data + " ->");

				if (currentNode.Right != null)
				{
					travStack.Push(currentNode.Right);
				}
				if (currentNode.Left != null)
				{
					travStack.Push(currentNode.Left);
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

		//using two stack ,https://www.youtube.com/watch?v=K2ybI-GEHSY&list=PLEJXowNB4kPzqcnf9CnjEcgP7r5LaSijB&index=1
		private void DisplayPostOrderIterative()
		{
			if (this.Root == null) return;
			Stack<Node> travStack = new Stack<Node>();
			travStack.Push(this.Root);
			Stack<Node> printStack = new Stack<Node>();
			Node currentNode = null;

			while (travStack.Count > 0)
			{
				currentNode = travStack.Pop();
				printStack.Push(currentNode);
				if (currentNode.Left != null) 
				{
					travStack.Push(currentNode.Left);
				}
				if (currentNode.Right != null)
				{
					travStack.Push(currentNode.Right);
				}
			}
		
			while (printStack.Count>0) 
			{
				Console.Write(printStack.Pop().Data + "->");			
			}
		}
		
		public int  DisplayKthSmallestElement(int nthSmallest) 
		{
			if(this.Root==null) 
			{
				return int.MinValue;
			}
			int[] kthsmall = {0,int.MinValue };
			FindKthSmallest(this.Root,kthsmall,nthSmallest);
			Console.WriteLine(kthsmall[1]);
			return kthsmall[1];
		}

		private void FindKthSmallest(Node currentNode,int[] kthsmall,int n) 
		{
			if (currentNode == null)
			{
				kthsmall[0] = 0;
				kthsmall[1] = int.MinValue;
				return;
			}
			FindKthSmallest(currentNode.Left,kthsmall,n);
			if (++kthsmall[0] == n) 
			{
				kthsmall[1] = currentNode.Data;
				return;
			}
			FindKthSmallest(currentNode.Right,kthsmall,n);
		}

		void INOrderTrav(Node CurrentNode) 
		{
			if (CurrentNode == null) return;
			INOrderTrav(CurrentNode.Left);
			Console.WriteLine(CurrentNode.Data);
			INOrderTrav(CurrentNode.Right);
			

		}

	}
}





		






