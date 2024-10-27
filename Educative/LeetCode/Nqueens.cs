public class Nqueen
{
	public int BoardSize = 0;
	List<IList<string>> results = new List<IList<string>>();

	public IList<IList<string>> SolveNQueens(int n)
	{
		BoardSize = n;

		char[][] boardState = new char[n][];

		for (int i = 0; i < n; i++)
		{
			boardState[i] = new char[BoardSize];
			for (int j = 0; j < n; j++)
			{
				boardState[i][j] = '.';
			}

		}

		HashSet<int> negativeDiagonal = new HashSet<int>();
		HashSet<int> postiveDiagonal = new HashSet<int>();
		HashSet<int> columns = new HashSet<int>();
		MoveToNextRow(0, columns, postiveDiagonal, negativeDiagonal, boardState);
		return results;


	}

	/*

    {
        {"Q...",".Q..","..Q.","...Q"} //invalid

    
    */
	public void MoveToNextRow(int row, HashSet<int> columnset, HashSet<int> postiveDiagonals,
	HashSet<int> negativeDiagonals, char[][] boardState)
	{
		if (row == BoardSize)
		{
			results.Add(AddResultFromBoardState(boardState));
			return;
		}

		int posDiagonal, negDiagnoal;
		for (int column = 0; column < BoardSize; column++)
		{

			posDiagonal = row + column;
			negDiagnoal = row - column;
			if (columnset.Contains(column) || postiveDiagonals.Contains(posDiagonal) || negativeDiagonals.Contains
			(negDiagnoal))
			{
				continue;
			}
			columnset.Add(column);
			postiveDiagonals.Add(posDiagonal);
			negativeDiagonals.Add(negDiagnoal);
			boardState[row][column] = 'Q';
			MoveToNextRow(row + 1, columnset, postiveDiagonals, negativeDiagonals, boardState);
			columnset.Remove(column);
			postiveDiagonals.Remove(posDiagonal);
			negativeDiagonals.Remove(negDiagnoal);
			boardState[row][column] = '.';

		}


	}

	public List<string> AddResultFromBoardState(char[][] boardState)
	{
		List<string> queenArrangements = new List<string>();
		for (int row = 0; row < BoardSize; row++)
		{
			queenArrangements.Add(new string(boardState[row]));

		}
		return queenArrangements;
	}

}