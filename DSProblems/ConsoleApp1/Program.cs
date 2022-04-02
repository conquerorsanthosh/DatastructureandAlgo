using System;
using DSProblems;

namespace DSAndAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Trie myTrie = new Trie();
			myTrie.Insert("cat");
			myTrie.Insert("catapult");
			myTrie.Insert("catapultasians");
			Console.WriteLine("dog--Present?"+  myTrie.search("Dog"));
			Console.WriteLine("cat--Present?" + myTrie.search("cat"));
			Console.ReadLine();
		}
	}
}
