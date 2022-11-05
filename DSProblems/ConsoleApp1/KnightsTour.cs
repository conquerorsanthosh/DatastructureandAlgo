using System;
using System.Collections.Generic;
using System.Text;

namespace DSProblems
{
	public class MyChessBoard
	{
		public int[,] Board;
		public int Size;
		public MyChessBoard(int n)
		{
			Size = n;
			Board = new int[n, n];
		}
		public int GetSqaureVal(int row, int column)
		{
			return Board[row, column];
		}
		public void SetSquareVal(int row, int column, int value)
		{
			Board[row, column] = value;
		}
		public int GetBoardSize()
		{
			return this.Size;
		}
		public void InitChessBoard(int value)
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
			for (int row = Board.GetLowerBound(0); row <= Board.GetUpperBound(0); row++)
			{
				for (int column = Board.GetLowerBound(1); column <= Board.GetUpperBound(1); column++)
				{
					Console.Write(Board[row, column] + "   ");
				}
				Console.WriteLine("");
			}

			Console.WriteLine("=======================================");
		}

	}

	public class KnightsTour
	{
		MyChessBoard myChessBoard;
		int N = 8;
		public KnightsTour() 
		{
			myChessBoard = new MyChessBoard(8);
			myChessBoard.InitChessBoard(-1);
		}

		public  void  DisplayKnightsTour() 
		{
			int[] knightMoveX = { 1, -1, -2, 2, 2, -2, 1, -1 };
			int[] knightMoveY = { -2, -2, -1, -1, 1, 1, 2, 2 };

			myChessBoard.Board[3, 3] = 1;
			GenerateKnightMoves(3, 3, knightMoveX, knightMoveY, 1);
		}

		private  bool GenerateKnightMoves(int currentX,int currentY,int[] knightMoveX,int[] knightMoveY,int move) 
		{
			if (move > N * N) 
			{
				//display the board
				return true;
			}

			
			for (int k = 0; k < N; k++) 
			{
				int nextX = currentX + knightMoveX[k];
				int nextY = currentY + knightMoveY[k];

				if (IsKnightMoveSafe(nextX, nextY)) 
				{
					myChessBoard.Board[nextX, nextY] = move+1;
					myChessBoard.PrintBoard();
					GenerateKnightMoves(nextX, nextY, knightMoveX, knightMoveY, move + 1);
				}
				else
				{
					myChessBoard.Board[nextX, nextY] = -1;
					myChessBoard.PrintBoard();
				}
			}
			return false;
		}

		private bool IsKnightMoveSafe(int currentX,int currenty) 
		{
			if (currentX > 0 && currentX <= N && currenty > 0 && currenty <= N) 
			{
				if (myChessBoard.Board[currentX, currenty] == -1) return false;
			}
			return false;
		}
	}
}
