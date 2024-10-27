using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 In leetcode this was giving OOM error

 */
namespace LeetCode
{
	public class SurroundedRegion
	{
		public void Solve(char[][] board)
		{
			int nr = board.Length;
			int nc = board[0].Length;
			bool [,] visited = new bool[nr, nc];
						
			for (int i = 0; i < nr; i++)
			{
				for (int j = 0; j < nc; j++)
				{
					if (board[i][j] == 'O')
					{
						CaptureNeighbours(i, j, nr, nc, board,visited);

					}

				}

			}


		}

		private bool DoesHaveValidNeighbour(int row, int col, int rowMax, int colMax)
		{
			if (row + 1 < rowMax && (row - 1) >=0 &&( col + 1) < colMax && (col - 1) >= 0)
			{
				return true;
			}
			return false;
		}

		private bool CheckMatrixRange(int row, int column, int rowMax, int columnMax)
		{
			if (row >= 0 && row < rowMax && column >= 0 && column < columnMax)
			{
				return true;
			}
			return false;
		}

		private void CaptureNeighbours(int row, int col, int rowMax, int colMax, char[][] board, bool[,] visited)
		{

			Queue<int[]> queue = new Queue<int[]>();
			int[] v = new int[] { row, col };
			queue.Enqueue(v);
			while (queue.Count > 0)
			{
				int[] vertex = queue.Dequeue();
				int r = vertex[0];
				int c = vertex[1];

				if (visited[r, c] == true) continue;

				if ( DoesHaveValidNeighbour(r, c, rowMax, colMax))
				{
					//mark as captured
					board[r][c] = 'X';
					visited[r, c] = true;
				}

				if (CheckMatrixRange(r + 1, c, rowMax, colMax) && visited[r + 1, c] == false && board[r + 1][c] == 'O')
				{
					queue.Enqueue(new int[] { r + 1, c });
				}
				if (CheckMatrixRange(r - 1, c, rowMax, colMax) && visited[r - 1, c] == false && board[r - 1][c] == 'O')
				{
					queue.Enqueue(new int[] { r - 1, c });
				}
				if (CheckMatrixRange(r, c + 1, rowMax, colMax) && visited[r, c + 1] == false && board[r][c + 1] == 'O')
				{
					queue.Enqueue(new int[] { r, c + 1 });
				}
				if (CheckMatrixRange(r, c - 1, rowMax, colMax) && visited[r, c - 1] == false && board[r][c - 1] == 'O')
				{
					queue.Enqueue(new int[] { r, c - 1 });
				}


			}
		}

	}
}
