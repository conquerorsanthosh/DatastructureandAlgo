using System;
using System.Collections.Generic;

namespace LeetCode;
public class SnakesAndLadders
{
    public int GetMinumumMoves(int[,]board) {
        int n = board.GetLength(0);
        Tuple<int, int>[] cells = new Tuple<int, int>[n * n + 1];
        int label = 1;
        int[] columns = new int[n];
        for (int i = 0; i < n; i++) {
            columns[i] = i;
        }
        for (int row = n - 1; row >= 0; row--) {
            foreach (int column in columns) {
                cells[label++] = new Tuple<int, int>(row, column);
            }
            Array.Reverse(columns);
        }
        int[] dist = new int[n * n + 1];
        for (int i = 0; i < dist.Length; i++) {
            dist[i] = -1;
        }

        Queue<int> q = new Queue<int>();
        dist[1] = 0;
        q.Enqueue(1);
        while (q.Count != 0) {
            int curr = q.Dequeue();
            for (int next = curr + 1; next <= Math.Min(curr + 6, n*n); next++) 
            {
                int row = cells[next].Item1, column = cells[next].Item2;
                int destination = board[row,column] != -1 ? board[row,column] : next;
                if (dist[destination] == -1) {
                    dist[destination] = dist[curr] + 1;
                    q.Enqueue(destination);
                }
            }
        }
        return dist[n * n];
    }
}
