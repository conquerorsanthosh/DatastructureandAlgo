//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NqueensProblem
//{
//	public class ChessBoard
//	{
//		bool[,] Board;
//		int Size;
//		ChessBoard(int n)
//		{
//			Size = n;
//			Board = new bool[n,n];
//		}
//		public bool GetSqaureVal(int row, int column)
//		{
//			return true;
//		}
//		public void SetSquareVal(int row, int column, bool value)
//		{
			
//		}
//		public int GetBoardSize() 
//		{
//			return this.Size;
//		}
//		public void InitChessBoard(bool value) 
//		{
//			for(int i=0;i<Board.GetUpperBound(0);i++)
//			{
//				for (int j = 0; j < Board.GetUpperBound(1); j++) 
//				{
//					Board[i,j] = value;
//				}
//			}
//		}
    
//	}

//	public static class NQueens 
//	{
//		public static int [,]SolveNQueeen(ChessBoard board) 
//		{

		
		
//		}
//		private int[,] GetAllValidQueenPositions(ChessBoard board,int currentColum) 
//		{
//			if (board.GetBoardSize() < currentColum) return null;
//			int nQueens = board.GetBoardSize();

//			for (int queen = 0; queen < nQueens; queen++)
//			{
//				for (int row = 0; row < board.GetBoardSize(); row++)
//				{


//				}
//			}
//			GetAllValidQueenPositions( board, currentColum + 1);
//		}
//		private bool  IsPositionSafe(int row, int column,ChessBoard board) 
//		{


//			return true;
//		}

//	}

//}
