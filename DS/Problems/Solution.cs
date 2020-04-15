using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class Solution
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            IList<int> smallestInRow = new List<int>();
            IList<int> largestInColumn = new List<int>();
            int rc = matrix.Length;
            int cc = matrix[0].Length;

            for (int i = 0; i < rc; i++)
            {
                int smallest = matrix[i][0];
                for (int j = 0; j < cc; j++)
                {
                    if (matrix[i][j] < smallest)
                        smallest = i * cc + j;
                }
                Console.WriteLine(smallest);
                smallestInRow.Add(smallest);
            }

            for (int i = 0; i < cc; i++)
            {
                int largest = matrix[0][i];
                for (int j = 0; j < rc; j++)
                {
                    if (matrix[j][i] > largest)
                        largest = i * cc + j;
                }
                Console.WriteLine(largest);
                largestInColumn.Add(largest);
            }

            // IEnumerable<int> res = smallestInRow.AsQueryable().Intersect(largestInColumn);
            //return res.ToList();
            return new List<int>();
        }
    }
}
