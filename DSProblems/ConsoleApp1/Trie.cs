using System;
using System.Collections.Generic;
using System.Text;

namespace DSProblems
{
	internal   class TrieNode
	{
		public Dictionary<char, TrieNode> childrens;
		public bool isEndOfWord;
		public TrieNode() 
		{
			childrens = new Dictionary<char, TrieNode>();
			isEndOfWord = false;		
		}
	}

	public class Trie
	{
		private TrieNode root;

		public Trie() 
		{
			root = new TrieNode();
		}
		public void Insert(string input) 
		{
			if (input==null) return;
			TrieNode current = root;
			for(int i = 0; i < input.Length; i++) 
			{
				if (current.childrens.ContainsKey(input[i])) 
				{
					current = current.childrens[input[i]];
				}
				else 
				{
					current.childrens[input[i]]  = new TrieNode();
					current = current.childrens[input[i]];
				}
			}
			current.isEndOfWord = true;
			Console.WriteLine("inserted" + input);
		}

		public bool search(string input)
		{
			if (input == null || root==null) return false ;
			TrieNode current = root;
			for (int i = 0; i < input.Length; i++)
			{
				if (current.childrens.ContainsKey(input[i]))
				{
					current = current.childrens[input[i]];

				}
				else 
				{
					return false;
				}
			}
			Console.WriteLine("isEndofWord"+current.isEndOfWord);
			return current.isEndOfWord;	

		}
	}
}
