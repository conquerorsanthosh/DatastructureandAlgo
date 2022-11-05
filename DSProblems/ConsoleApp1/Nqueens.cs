using System;
using System.Collections.Generic;
using System.Text;

namespace NqueensProblem
{
	public class ChessBoard
	{
		public bool[,] Board;
		public int Size;
		public ChessBoard(int n)
		{
			Size = n;
			Board = new bool[n, n];
		}
		public bool GetSqaureVal(int row, int column)
		{
			return Board[row,column];
		}
		public void SetSquareVal(int row, int column, bool value)
		{
			Board[row, column] = value;
		}
		public int GetBoardSize()
		{
			return this.Size;
		}
		public void InitChessBoard(bool value)
		{
			for (int i = 0; i <= Board.GetUpperBound(0); i++)
			{
				for (int j = 0; j <= Board.GetUpperBound(1); j++)
				{
					Board[i, j] = value;
				}
			}
		}

		public void PrintBoard()
		{
			for(int row = Board.GetLowerBound(0); row <= Board.GetUpperBound(0); row++) 
			{
				for (int column = Board.GetLowerBound(1); column <= Board.GetUpperBound(1); column++) 
				{
					Console.Write(Board[row, column] + "   ");
				}
				Console.WriteLine("");
			}
		}

	}

	

	public static class NQueens
	{
		public static bool SolveNQueeen(ChessBoard board,int column)
		{
			if (column > board.Size) 
			{
				board.PrintBoard();
				return true;
			
			}
			for (int row = 0; row <= board.Board.GetUpperBound(0); row++)
			{
				if (IsPositionSafe(row, column, board))
				{
					board.Board[row, column] = true;
					if (SolveNQueeen(board, column + 1))
					{
						return true;
					}
					board.Board[row, column] = false;
				}
			}
			return false;
		}

		
		private static bool IsPositionSafe(int row, int column, ChessBoard board)
		{
			//Check if all the row are safe for given column
			//Check if  upper left diagnoal is safe.
			//Check if lower diagonal is safe.

			// we dont need to validate different columns because we are placing only one queen in one column
			// we dont need to check columns on the right side because we havent processed it
			// we dont need to check right upper and lowe diagonals because we haven't filled it yet.

			for(int c = column; c >=0;c--) 
			{
				if (c!=column) 
				{
					if(board.Board[row, c] == true) 
					{
						return false;
					}
				}
			}

			for (int r = row, c = column; r >= 0 && c >= 0; r--, c--) 
			{
				if(r!=row && column != c) 
				{
					if (board.Board[r, c] == true) return false;
				
				}
			}

			for (int r = row, c = column; r <= board.Board.GetUpperBound(0) && c >= 0; r++, c--)
			{
				if (r != row && column != c)
				{
					if (board.Board[r, c] == true) return false;

				}
			}

			return true;
		}

	}

}
