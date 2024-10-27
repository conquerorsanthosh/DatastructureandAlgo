using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

	//grid = [
	// ["1","1","1","1","0"],
	// ["1","1","0","1","0"],
	// ["1","1","0","0","0"],
	// ["0", "0", "0", "0", "0"]
	public class NumberOfIslands
	{
		public int NumIslands(char[][] grid)
		{
			int count = 0;
			int nr = grid.Length;
			int nc = grid[0].Length;
			for (int i = 0; i < nr; i++)
			{
				for (int j = 0; j < nc; j++)
				{
					if (grid[i][j] == '1')
					{
						count++;
						//CheckForNeighbourIsland(grid, i, j, nr, nc);
						CheckForNeighbourIslandBFS(grid, i, j, nr, nc);
					}

				}
			}
			return count;
		}

		private bool CheckMatrixRange(int row, int column, int rowMax, int columnMax)
		{
			if (row >= 0 && row < rowMax && column >= 0 && column < columnMax)
			{
				return true;
			}
			return false;
		}

		private void CheckForNeighbourIsland(char[][] grid, int row, int column, int rowMax, int columnMax)
		{
			if (!CheckMatrixRange( row, column, rowMax, columnMax))
			{
				return;
			}

			if (grid[row][column] != '1')
			{
				return;
			}

			grid[row][column] = '2';
			CheckForNeighbourIsland(grid, row, column + 1, rowMax, columnMax);
			CheckForNeighbourIsland(grid, row, column - 1, rowMax, columnMax);
			CheckForNeighbourIsland(grid, row - 1, column, rowMax, columnMax);
			CheckForNeighbourIsland(grid, row + 1, column, rowMax, columnMax);
			return;
		}
		public class Vertex
		{
			public int r;
			public int c;

			public Vertex(int row,int col) 
			{
				r = row;
				c = col;
			}

		}


		private void CheckForNeighbourIslandBFS(char[][] grid, int row, int column, int rowMax, int columnMax)
		{
			Queue<Vertex> vQueue = new Queue<Vertex>();
			vQueue.Enqueue(new Vertex(row, column)); 

			while (vQueue.Count > 0) 
			{
				Vertex vertex = vQueue.Dequeue();
				grid[vertex.r][vertex.c] = '2';
				if (CheckMatrixRange(vertex.r + 1, vertex.c, rowMax, columnMax)&& grid[vertex.r+1][vertex.c]=='1')
				{
						vQueue.Enqueue(new Vertex(vertex.r + 1, vertex.c));
				}
				if (CheckMatrixRange(vertex.r - 1, vertex.c, rowMax, columnMax)&& grid[vertex.r-1][vertex.c] == '1' )
				{
					vQueue.Enqueue(new Vertex(vertex.r - 1, vertex.c));
				}

				if (CheckMatrixRange(vertex.r, vertex.c + 1, rowMax, columnMax)&&grid[vertex.r][vertex.c+1] == '1' )
				{
					vQueue.Enqueue(new Vertex(vertex.r , vertex.c+1));
				}

				if (CheckMatrixRange(vertex.r, vertex.c - 1, rowMax, columnMax)&& grid[vertex.r][vertex.c-1] == '1' )
				{
					vQueue.Enqueue(new Vertex(vertex.r, vertex.c - 1));
				}

			}
			vQueue.Clear();

		}
	}
}
