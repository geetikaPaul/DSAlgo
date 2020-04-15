using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Heap
    {
        public int Left(List<int> arr, int i)
        {
            return 2 * i + 1;
        }
        public int Right(List<int> arr, int i)
        {
            return 2 * i + 2;
        }
        public void MaxHeapify(List<int> arr, int i)
        {
            int left = Left(arr, i);
            int right = Right(arr, i);

            int heapSize = arr.Count;
            int largest = i;

            if (left < heapSize && arr[left] > arr[largest])
                largest = left;
            if (right < heapSize && arr[right] > arr[largest])
                largest = right;

            if (i != largest)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                MaxHeapify(arr, largest);
            }
        }

        public void BuildMaxHeap(List<int> arr)
        {
            int len = arr.Count;
            for (int i = (int)Math.Floor((double)len / 2) - 1; i >= 0; i--)
                MaxHeapify(arr, i);
        }

        public int ExtractMax(List<int> arr)
        {
            int len = arr.Count;
            int maxValue = arr[0];
            arr[0] = arr[len - 1];
            arr.RemoveAt(len - 1);
            MaxHeapify(arr, 0);
            return maxValue;
        }

        public void DecreaseKey(List<int> arr, int key, int newValue)
        {
            if (arr[key] < newValue)
                return;
            arr[key] = newValue;
            MaxHeapify(arr, key);
        }
        public void MinHeapify(List<int> arr, int i)
        {
            int left = Left(arr, i);
            int right = Right(arr, i);

            int heapSize = arr.Count;
            int smallest = i;

            if (left < heapSize && arr[left] < arr[i])
                smallest = left;
            if (right < heapSize && arr[right] < arr[smallest])
                smallest = right;

            if (smallest != i)
            {
                int temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
                MinHeapify(arr, smallest);
            }
        }

        public void BuildMinHeap(List<int> arr)
        {
            int len = arr.Count;
            for(int i=(int)Math.Floor((double)(len-1)/2);i>=0;i--)
            {
                MinHeapify(arr, i);
            }
        }
        
        public int ExtractMin(List<int> arr)
        {
            int len = arr.Count;
            int result = arr[0];
            arr[0] = arr[len - 1];
            arr.RemoveAt(len - 1);
            MinHeapify(arr, 0);
            return result;
        }
    }
}
 