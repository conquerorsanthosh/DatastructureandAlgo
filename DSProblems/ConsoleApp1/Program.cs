using System;
using DSProblems;
using NqueensProblem;


namespace DSAndAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			//Trie myTrie = new Trie();
			//myTrie.Insert("cat");
			//myTrie.Insert("catapult");
			//myTrie.Insert("catapultasians");
			//Console.WriteLine("dog--Present?"+  myTrie.search("Dog"));
			//Console.WriteLine("cat--Present?" + myTrie.search("cat"));
			//myTrie.PrintAllWords();


			//int[] arr = { 7, 3, 1, 8, 9, 10, 4, 5, 6 };
			//int n = arr.Length;
			//int maxDiff = GFG.maxIndexDiff(arr, n);
			//Console.Write(maxDiff);
			//Console.ReadLine();


			//Nqueens Problem

			//ChessBoard board = new ChessBoard(4);
			//board.InitChessBoard(false);
			//board.PrintBoard();
			//NQueens.SolveNQueeen(board, 0);

			//KnightsTour knightsTour = new KnightsTour();
			//knightsTour.DisplayKnightsTour();

			//int[] source = { 4, 5, 3, 45, 8, 9, 10 };
			//ArrayRotation.PostiveandNegativeRotation(source, 7, 4);

			BinarySearchTree binarySearchTree = new BinarySearchTree();
			binarySearchTree.InsertData(40);
			binarySearchTree.InsertData(20);
			binarySearchTree.InsertData(25);
			binarySearchTree.InsertData(15);
			binarySearchTree.InsertData(60);
			binarySearchTree.InsertData(55);
			binarySearchTree.InsertData(75);
			binarySearchTree.DisplayAllTraversals();
			Console.ReadKey();

		}
	}
}
