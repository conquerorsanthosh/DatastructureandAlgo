using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public static class SpiralMatrix
	{
		public static void PrintSpiral(int[,] matrix) 
		{
			int total = matrix.GetLength(0)*matrix.GetLength(1);
			Console.WriteLine("total number of elements are " + total);

			List<int> result = new List<int>();

			int leftBoundary = 0;
			int rightBoundary = matrix.GetLength(1)-1;
			int upBoundary = 0;
			int downBoundary = matrix.GetLength(0)-1 ;

			//Console.WriteLine("Following are boundaries");
			//Console.WriteLine("left:" + leftBoundary);
			//Console.WriteLine("right" + rightBoundary);
			//Console.WriteLine("up" + upBoundary);
			//Console.WriteLine("down" + downBoundary);


			while(total > 0) 
			{
				if (total == 0) break;
				//Console.WriteLine("remaining elements to be printed" + total);
				
				//left to right
				for(int lr = leftBoundary; lr <=rightBoundary; lr++) 
				{
					Console.WriteLine("element at [{0},{1}]:{2} ", leftBoundary, lr, matrix[leftBoundary, lr]);
					result.Add(matrix[upBoundary,lr]);
					--total;
					//Console.WriteLine("remaining elements to be printed" + total);
				}

				//up to down
				if ((rightBoundary != leftBoundary) && (upBoundary != downBoundary))
				{
					for (int ud = upBoundary + 1; ud <= downBoundary; ud++)
					{
						Console.WriteLine("element at [{0},{1}]:{2} ", ud, downBoundary, matrix[ud, downBoundary]);
						result.Add(matrix[ud, rightBoundary]);
						--total;
						//Console.WriteLine("remaining elements to be printed" + total);
					}
				}

				//right to left
				if ((rightBoundary != leftBoundary) && upBoundary != downBoundary) 
				{
					for (int rl = rightBoundary - 1; rl >= leftBoundary; rl--)
					{
						Console.WriteLine("element at [{0},{1}]:{2} ", rightBoundary, rl, matrix[rightBoundary, rl]);
						result.Add(matrix[downBoundary, rl]);
						--total;
						//Console.WriteLine("remaining elements to be printed" + total);
					}
				}

				//down to up
				for(int du=downBoundary-1; du > upBoundary; du-- )
				{
					Console.WriteLine("element at [{0},{1}]:{2} ", du, upBoundary, matrix[du,upBoundary]);
					result.Add(matrix[du,leftBoundary]);
					--total;
					//Console.WriteLine("remaining elements to be printed" + total);
				}
	
				leftBoundary++;
				rightBoundary--;
				upBoundary++;
				downBoundary--;

				//Console.WriteLine("Following are the modified boundaries");
				//Console.WriteLine("left:" + leftBoundary);
				//Console.WriteLine("right" + rightBoundary);
				//Console.WriteLine("up" + upBoundary);
				//Console.WriteLine("down" + downBoundary);
			}

			foreach(int ud in result) { Console.WriteLine(ud); }
		}
		
	}
}
