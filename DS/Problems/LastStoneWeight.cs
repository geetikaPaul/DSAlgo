using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Problems
{
    public class LastStoneWeight
    {
        private Heap heap = new Heap();
public int LastStoneWeightCalc(int[] stones)
        {
            List<int> stonesList = stones.ToList();
            int cntZeroes = 0;
            int maxIterations = stones.Length - 1;

            heap.BuildMaxHeap(stonesList);
            while (cntZeroes < maxIterations)
            {
                int largest = stonesList[0];
                int secondLargestIndex = heap.Left(stonesList, 0);
                if (stonesList.Count > 2)
                 secondLargestIndex = stonesList[secondLargestIndex] > stonesList[heap.Right(stonesList, 0)] ?
                    secondLargestIndex : heap.Right(stonesList, 0);
                if(largest==stonesList[secondLargestIndex])
                {
                    stonesList[0] = 0;
                    stonesList[secondLargestIndex] = 0;
                    cntZeroes += 2;
                }
                else
                {
                    stonesList[0] = largest - stonesList[secondLargestIndex];
                    stonesList[secondLargestIndex] = 0;
                    cntZeroes += 1;
                }

                heap.BuildMaxHeap(stonesList);
            }
            if (stonesList.Count == 0)
                return 0;
            return stonesList[0];
        }
    }
}
