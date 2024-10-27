namespace LeetCode
{

	public class Coordinates
	{
		public int row;
		public int column;

		public Coordinates(int row, int column)
		{
			this.row = row;
			this.column = column;
		}
	}
	public class MySnakeAndLadders
	{
		int[,] gameBoard;
		int size = 0;

		public MySnakeAndLadders(int[,] board, int n)
		{
			gameBoard = board;
			size = n;
		}

		public int GetMinimumRolls()
		{
			int numOfCells = size * size;
			List<Coordinates> coordinatesList = new List<Coordinates>();
			bool isReverse = false;
			//convert board into linear structure
			for (int row = size - 1; row >= 0; row--)
			{
				if (!isReverse)
				{
					for (int column = 0; column <= size - 1; column++)
					{
						isReverse = true;
						Coordinates coordinates = new Coordinates(row, column);
						coordinatesList.Add(coordinates);

					}
				}
				else
				{
					for (int column = size - 1; column >= 0; column--)
					{
						isReverse = false;
						Coordinates coordinates = new Coordinates(row, column);
						coordinatesList.Add(coordinates);
					}
				}
			}

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(1);
			int[] distance = new int[size * size];

			for (int cell = 0; cell < size * size; cell++)
			{
				distance[cell] = -1;
			}
			distance[0] = 0;
			while (queue.Count > 0)
			{
				int currentCell = queue.Dequeue();
				int nextCell = 0;

				for (int dice = 1; dice <= 6; dice++)
				{
					int boardValue = gameBoard[coordinatesList[currentCell - 1].row, coordinatesList[currentCell - 1].column];
					if (boardValue == -1)
					{
						nextCell = currentCell + 1;
					}
					else
					{
						nextCell = boardValue;
					}

					if (distance[nextCell] == -1 || distance[nextCell - 1] > distance[currentCell - 1] + 1)
					{
						distance[nextCell - 1] = distance[currentCell - 1] + 1;
					}
				}

			}
			return distance[(size * size) - 1];
		}

	}
}


