using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving
{
	public static class MyproblemSolvingClass
	{

		public static int FindMajorityElement_1(int[] input, int n)
		{
			Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

			for (int k = 0; k < n; k++)
			{
				frequencyMap[input[k]] = frequencyMap[input[k]] + 1;
				
			}

			var sortedDictionary = from entry in frequencyMap orderby entry.Value ascending select entry;
			foreach(KeyValuePair< int,int> pair in sortedDictionary) 
			{
				Console.WriteLine(pair.Key + "::" + pair.Value);
			}
			return -1;
		}
	}
}
