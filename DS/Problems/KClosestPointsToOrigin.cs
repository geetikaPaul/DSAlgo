using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class MinHeap
    {
        public int Left(double[][] arr, int i)
        {
            return 2 * i + 1;
        }
        public int Right(double[][] arr, int i)
        {
            return 2 * i + 2;
        }
        public void MinHeapify(double[][] arr, int i)
        {
            int left = Left(arr, i);
            int right = Right(arr, i);

            int heapSize = arr.Length;
            int smallest = i;

            if (left < heapSize && arr[left][1] < arr[i][1])
                smallest = left;
            if (right < heapSize && arr[right][1] < arr[smallest][1])
                smallest = right;

            if (smallest != i)
            {
                double[][] temp = new double[1][];
                temp[0][0] = arr[i][0];
                temp[0][1] = arr[i][1];
                arr[i][0] = arr[smallest][0];
                arr[i][1] = arr[smallest][1];
                arr[smallest][0] = temp[0][0];
                arr[smallest][1] = temp[0][1];
                MinHeapify(arr, smallest);
            }
        }

        public void BuildMinHeap(double[][] arr)
        {

            int len = arr.Length;          
            for (int i = (int)Math.Floor((double)(len - 1) / 2); i >= 0; i--)
            {
                MinHeapify(arr, i);
            }
        }

        public double ExtractMin(double[][] arr)
        {
            int len = arr.Length;
            double result = arr[0][0];
            arr[0] = arr[len - 1];
            for(int i=1;i<len-1;i++)
            {
                arr[i] = arr[i];
            }
            MinHeapify(arr, 0);
            return result;
        }
    }

   public class KClosestPointsToOrigin
    {
        /*public int[][] KClosest(int[][] points, int K)
        {
            int len = points.Length;
            double[][] distances = new double[len][];
            for(int i=0; i< len; i++)
            {
                distances[i][0] = i;
                distances[i][1] = Math.Sqrt(Math.Pow(points[i][0], 2)+ Math.Pow(points[i][1], 2));
            }

            MinHeap minHeap = new MinHeap();
            minHeap.BuildMinHeap(distances);
            while(K>0)
            {

                K--;
            }

            return new int[][]
        }*/
    }
}
