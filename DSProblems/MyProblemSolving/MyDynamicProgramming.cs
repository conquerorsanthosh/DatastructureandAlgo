using System;
using System.Collections.Generic;
using System.Text;

namespace MyProblemSolving
{
	/*
	 *
	 
	 */

	public static class MyDynamicProgramming
	{

		/*
		 * 
		 * 
		 * Print all Paths with Minimum Jumps Dynamic Programming 
		 1. https://www.youtube.com/watch?v=phgjL7SbsWs
	 
	 	2. Alternate Solution ( Possibly will not work for multiple path)
		https://github.com/mission-peace/interview/blob/master/src/com/interview/dynamic/MinJumpToReachEnd.java
 
		 
		 */



		public static void PrintStartToEndPath(int[] source, int n) 
		{

			/*
			 1. Build an array which contains min jumps required to reach the last index in the array, we need to build this starting 
			     from the last index
			 2. For each index find a index which will take minimum jump to reach the last index.
			 3. There may be multiple paths we need to print all of them.
	      */

			int[] minJumpsForEachIndex = new int[n];
			minJumpsForEachIndex[n - 1] = 0;

			for(int k = n - 2; k >= 0; k--) 
			{
				if (source[k] > 0)
				{
					int min = int.MaxValue;
					for (int j = 1; j <= source[k]; j++)
					{
						if ((k + j) <= (n - 1) && minJumpsForEachIndex[k + j] < min)
						{
							min = minJumpsForEachIndex[k + j];
						}
						minJumpsForEachIndex[k] = min + 1;
					}
				}
			
				else 
				{
					minJumpsForEachIndex[k] = -1;
				}
			}

			
			

			
		}
	}
}
