using System;
using System.Collections.Generic;
using System.Text;

namespace DSProblems
{
	public class FindCandidatesForGivenSum
	{
		/*
		 * Input  A[]={5,6,2,1,8}  sum =8 
		 * Output=
		 * 8,
		 * 6+2=8
		 * 5+2+1=8
		 *  5+1+1+1=8 
		 *  6+1+1=8 (Number can be repeatedly used)
		 *   		 
		 */
		
		public static List<List<int>>  FindCandidates(List<int> numbers,int sum) 
		{
			List<List<int>> candidates = new List<List<int>>();
			PrepareCandidates(numbers, sum, ref candidates, 0);
			return candidates;

		}
		private static bool PrepareCandidates(List<int> numbers, int sum,ref List<List<int>> candidates,int index) 
		{
			if (sum == 0) return true;
			if (sum < 0) return false;
			int remainder = -1;
			bool canAddToList = false;
			for(int i=0;i<numbers.Count;i++)
			{
				remainder = sum -numbers[i];
				canAddToList = PrepareCandidates(numbers, sum, ref candidates,index);
				if (canAddToList) 
				{
					candidates[index].Add(numbers[i]);
					return true;
				}
			}
			return false;
		}
	}
}
