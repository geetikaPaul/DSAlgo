using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class CountCommunicatingServers
    {
        public int func(int[][] grid)
        {
            int result = 0;

            int rowCount = grid.Length;
            int colCount = grid[0].Length;

            int[][] computersConnected = new int[rowCount][];

            for (int i = 0; i < rowCount; i++)
            {
                computersConnected[i] = new int[colCount];
                for (int j = 0; j < colCount; j++)
                {
                    computersConnected[i][j] = 0;
                }
            }

            for (int i=0;i<rowCount;i++)
            {
                int numberOfComputers = 0;
                for(int j=0;j<colCount;j++)
                {
                    if (grid[i][j]==1)
                        numberOfComputers++;
                    if (numberOfComputers > 1)
                        break;
                }

                if(numberOfComputers>1)
                    for (int j = 0; j < colCount; j++)
                    {
                        if (grid[i][j] == 1)
                            computersConnected[i][j] = 1;
                    }
            }

            for (int i = 0; i < colCount; i++)
            {
                int numberOfComputers = 0;
                for (int j = 0; j < rowCount; j++)
                {
                    if (grid[j][i] == 1)
                        numberOfComputers++;
                    if (numberOfComputers > 1)
                        break;
                }

                if (numberOfComputers > 1)
                    for (int j = 0; j < rowCount; j++)
                    {
                        if(grid[j][i] == 1)
                            computersConnected[j][i] = 1;
                    }
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    result += computersConnected[i][j];
                }
            }
            return result;
        }
    }
}
