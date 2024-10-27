using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public  class NumIslands
	{
		int[,] _matrix;
		HashSet<string> _visited;
		int _islandcount;

		public NumIslands(int[,] matrix) 
		{
			_matrix = matrix;
			_visited = new HashSet<string>();
			_islandcount = 0;
		}
		public int FindNumIslands() 
		{
			for(int i = 0; i < _matrix.GetLength(0); i++) 
			{
				for (int j = 0; j < _matrix.GetLength(1); j++) 
				{
					if (_matrix[i,j] == 1) 
					{
						if (ExploreByDFS(i, j))
						{
							++_islandcount;
						}
						
					}
				
				}
			}
			return _islandcount;
		}

		private bool ExploreByDFS(int row,int column) 
		{
			if(!CheckMatrixRange(row, column))  return false;
			if (_matrix[row,column] == 0) return false;
			if (_visited.Contains(row.ToString() + column.ToString())) return false;
			_visited.Add(row.ToString() + column.ToString());
			
			ExploreByDFS(row - 1, column);
			ExploreByDFS(row + 1, column);
			ExploreByDFS(row, column - 1);
			ExploreByDFS(row, column + 1);
			return true;
		}
		private bool CheckMatrixRange(int row,int column) 
		{
			if (row >= 0 && row < _matrix.GetLength(0))
			{
				if (column >= 0 && column < _matrix.GetLength(1)) 
					return true;
			}
			return false;
		}

	}
}
