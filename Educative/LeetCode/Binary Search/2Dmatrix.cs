using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{

	public class _2Dmatrix
	{
		public bool SearchMatrix(int[][] matrix, int target)
		{
			int nRows = matrix.Length;
			int nColumns = matrix[0].Length;
			int tRow = -1;

			//find the row where the element is located
			//tRow=FindPotentialRow(nRows,nColumns,matrix,target);
			tRow = FindPotentialRowBinarySearch(nRows, nColumns, matrix, target);

			if (tRow != -1)
			{
				// we found the Row , Apply Binary search on the same

				int left = 0;
				int right = nColumns - 1;
				int mid = -1;

				while (left <= right)
				{
					mid = (left + right) / 2;

					if (matrix[tRow][mid] == target)
					{
						return true;
					}

					if (matrix[tRow][mid] > target)
					{
						right = mid - 1;
					}
					else
					{
						left = mid + 1;
					}
				}

			}

			return false;

		}

		private int FindPotentialRow(int nRows, int nColumns, int[][] matrix, int target)
		{
			for (int i = 0; i < nRows; i++)
			{
				if (target == matrix[i][0] || target == matrix[i][nColumns - 1])
				{
					return i;
				}

				if (target > matrix[i][0] && target < matrix[i][nColumns - 1])
				{
					return i;
				}
			}
			return -1;
		}

		private int FindPotentialRowBinarySearch(int nRows, int nColumns, int[][] matrix, int target)
		{
			int left = 0;
			int right = nRows - 1;
			int col = 0;
			int mid = -1;

			while (left <= right)
			{
				mid = (left + right) / 2;

				if (target >= matrix[mid][col] && target <= matrix[mid][nColumns - 1])
				{
					return mid;
				}

				else if (target > matrix[mid][nColumns - 1])
				{
					left = mid + 1;
				}

				else
				{
					right = mid - 1;
				}
			}
			return -1;

		}


	}
}
