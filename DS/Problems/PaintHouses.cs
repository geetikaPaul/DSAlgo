using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Problems
{
    public class PaintHouses
    {
        public int MinCost(int[][] costs)
        {
            int numOfHouses = costs.Length;
            int[] houseColor = new int[numOfHouses];
            int[] costOfColor = new int[numOfHouses];
            int totalCost = 0;

            int color = IndexOfMin(costs[0].ToList());
            costs[0][color] = 100000;
            houseColor[0] = color;
            costOfColor[0] = costs[0][color];

            for (int i = 1; i < numOfHouses; i++)
            {
                int newColor = costs[i].ToList().Min();
                if (houseColor[i - 1] != newColor)
                {
                    color = IndexOfMin(costs[i].ToList());
                    costs[i][color] = 100000;
                    houseColor[i] = color;
                    costOfColor[i] = costs[i][color];
                }
                else
                {

                }
            }

            return totalCost;
        }

        public int IndexOfMin(IList<int> self)
        {
            if (self == null)
            {
                throw new ArgumentNullException("self");
            }

            if (self.Count == 0)
            {
                throw new ArgumentException("List is empty.", "self");
            }

            int min = self[0];
            int minIndex = 0;

            for (int i = 1; i < self.Count; ++i)
            {
                if (self[i] < min)
                {
                    min = self[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
