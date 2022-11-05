using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace MyProblemSolving
{
	public static class MyproblemSolvingClass
	{
		public static int FindMajorityElement_1(int[] input, int n)
		{
			Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
			for (int k = 0; k < n; k++)
			{
				if (frequencyMap.ContainsKey(input[k]))
				{
					frequencyMap[input[k]] = frequencyMap[input[k]] + 1;
				}
				else 
				{
					frequencyMap[input[k]] = 0;
					frequencyMap[input[k]]++;
				}
			}

			var max=frequencyMap.Aggregate((a, b) => a.Value > b.Value ? a:b).Key;
			var sortedDictionary = from entry in frequencyMap orderby entry.Value ascending select entry;
			foreach (KeyValuePair<int, int> pair in sortedDictionary)
			{
				Console.WriteLine(pair.Key + "::" + pair.Value);
			}

			//Console.ReadLine();
			return -1;
		}

		//https://www.youtube.com/watch?v=vcv3REtIvEo&t=0s
		public static int  FindMaxRectangleInHistogram(int[]height,int n)
		{
			Stack<int> minStack = new Stack<int>();
			int[] leftMinimum = new int[n];
			int[]rightMinimum= new int[n];

			if (n <= 0)
			{
				return -1;
			}

			/*
			 1. Build left min array for each of the bar graph
			 2. Build right min array for each of the bar graph
			 3. (Right-Left) * height of the bar graph will give the area of the rectangle.		 
			 */
	
			for(int k = 0; k < n; k++) 
			{
				if (minStack.Count == 0) 
				{
					leftMinimum[k] = 0;
					minStack.Push(0);
				}
				else 
				{
					while(minStack.Count>0 && height[k] <= height[minStack.Peek()]) 
					{
						minStack.Pop();
					}
					leftMinimum[k] = minStack.Count == 0 ? 0 : minStack.Peek() + 1;
					minStack.Push(k);
				 }
			}

			while (minStack.Count != 0) 
			{
				minStack.Pop();
			}
			//calculate the right minimum array
			for(int k = n - 1; k >= 0; k--) 
			{
				if (minStack.Count == 0)
				{
					rightMinimum[k] = n - 1;
					minStack.Push(n - 1);
				}
				else 
				{
					while (minStack.Count != 0 && height[minStack.Peek()] >= height[k]) 
					{
						minStack.Pop();
					}
					rightMinimum[k] = minStack.Count == 0 ? n - 1 : minStack.Peek() - 1;
					minStack.Push(k);
				}
			}

			//Calcuate the area
			int[] area = new int[n];

			Console.WriteLine("{Index}   {Width}  {Height}   {Area}");
			for (int k = 0; k < n; k++) 
			{
				area[k] = (rightMinimum[k] - leftMinimum[k] + 1) * height[k];
				Console.WriteLine("{0}   {1}  {2}   {3}", k, (rightMinimum[k] - leftMinimum[k] + 1), height[k], area[k]);
			}
			Console.WriteLine("Max-Area"+area.Max());
			Console.ReadLine();
			return area.Max();
		}

		public static int FindMaxRectangleInBinaryMatrix(int[,] matrix,int nRows,int nColumns) 
		{
			if (matrix != null && nRows <= 0 && nColumns <= 0) 
				return-1;
			
			Dictionary<int, int[]> rowToHistogramMap = new Dictionary<int, int[]>();
			for(int currentRow = 0; currentRow < nRows; currentRow++) 
			{
				rowToHistogramMap[currentRow] = new int[nColumns];
				rowToHistogramMap[currentRow]=ConvertEachRowToHistogram(matrix, currentRow, nColumns);
			}

			int[] Area = new int[nRows];
		
			foreach(KeyValuePair<int,int[]> keyValuePair in rowToHistogramMap) 
			{
				Area[keyValuePair.Key] = MyproblemSolvingClass.FindMaxRectangleInHistogram(keyValuePair.Value, nColumns);
			}
			Console.WriteLine("MaxRectangleinMatrix" + Area.Max());
			return -1;
		}
		
		private static int[] ConvertEachRowToHistogram(int[,]binMatrix, int rowNumber,int nCloumns) 
		{
			int[] rowHistogram= new int[nCloumns];
			if (rowNumber == 0) 
			{
				for (int i = 0; i < nCloumns; i++) 
				{
					rowHistogram[i] = binMatrix[rowNumber,i];
				}
				return rowHistogram;
			}

			for(int i=0;i< nCloumns; i++) 
			{
				for(int currentRownumber = rowNumber; currentRownumber >=0; currentRownumber--) 
				{
					if (binMatrix[currentRownumber,i] == 1) 
					{
						rowHistogram[i]++;
					}
				}
			}

			return rowHistogram;
		}
	}
}
