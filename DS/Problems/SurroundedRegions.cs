using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class SurroundedRegions
    {
        public bool DFS(int i, int j, char[][] board, bool[][] visited)
        {
            if ((i - 1 == 0 && board[i - 1][j] == 'O') || (i + 1 == board.Length - 1 && board[i + 1][j] == 'O') ||
                (j - 1 == 0 && board[i][j - 1] == 'O') || (j + 1 == board[0].Length - 1 && board[i][j + 1] == 'O'))
            {
                visited[i][j] = true;
                return false;
            }

            if (board[i][j] == 'X')
                return true;

            board[i][j] = 'X';

            if ((board[i - 1][j] == 'X' || (!visited[i-1][j] && DFS(i - 1, j, board, visited))) &&
                       (board[i][j - 1] == 'X' || (!visited[i][j-1] && DFS(i, j - 1, board, visited))) &&
                       (board[i + 1][j] == 'X' || (!visited[i+1][j] && DFS(i + 1, j, board, visited))) &&
                       (board[i][j + 1] == 'X' || (!visited[i][j+1] && DFS(i, j + 1, board, visited))))                
                return true;

            visited[i][j] = true;
            board[i][j] = 'O';
            return false;
        }
        public void Solve(char[][] board)
        {
            int rowCount = board.Length;
            int colCount = board[0].Length;

            bool[][] visited = new bool[rowCount][];

            for(int i=0;i<rowCount;i++)
            {
                visited[i] = new bool[colCount];
                for (int j = 0; j < colCount; j++)
                    visited[i][j] = false;
            }

            for (int j = 0; j < colCount; j++)
            {
                visited[0][j] = true;
                visited[rowCount-1][j] = true;
            }
            for (int j = 0; j < rowCount; j++)
            {
                visited[j][0] = true;
                visited[j][colCount-1] = true;
            }

            for (int i = 1; i < rowCount - 1; i++)
            {
                for (int j = 1; j < colCount - 1; j++)
                {
                    if(!visited[i][j] && board[i][j]=='O')
                        DFS(i, j, board, visited);
                }
            }
        }
    }
}
