using System;
using System.Collections.Generic;
using System.Text;

namespace DSProblems
{
	public   class TrieNode
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
		public List<string> PrintAllWords() 
		{
			if (this.root == null || this.root.childrens.Count<=0) 
				return null;

			List<string> allWords = new List<string>();
			foreach(var key  in root.childrens.Keys) 
			{
				PrintAllChildren(root.childrens[key], key, "", ref allWords);
			}
			Console.WriteLine("printing all the words in the Trie");
			allWords.ForEach(word=>Console.WriteLine(word));
			return allWords;
		}

		/*
		 * 
		 *==For each of the childeren find all the possible children origniating at the children
		 *==For single children, check if it has children or if its a end of the word.
		 *==if it is end of the word , then 
		 *
		*/

		public void PrintAllChildren(TrieNode current, char c, string word, ref List<string> allWords) 
		{
			word += c.ToString();
			if (current.isEndOfWord) 
			{
				allWords.Add(word);
				//return;
			}
	
			foreach (var key in current.childrens.Keys)
			{
				PrintAllChildren(current.childrens[key], key, word,ref allWords);
			}
		}

	}
}
