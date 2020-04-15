using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class HeapWithDuplicates
    {
        public class HeapNode
        {
            public int key { get; set; }
            public int value { get; set; }
        }
        public int Left(List<HeapNode> arr, int i)
        {
            return 2 * i + 1;
        }
        public int Right(List<HeapNode> arr, int i)
        {
            return 2 * i + 2;
        }
        public void MaxHeapify(List<HeapNode> arr, int i)
        {
            int left = Left(arr, i);
            int right = Right(arr, i);

            int heapSize = arr.Count;
            int largest = i;

            if (left < heapSize && arr[left].key > arr[largest].key)
                largest = left;
            if (right < heapSize && arr[right].key > arr[largest].key)
                largest = right;

            if (i != largest)
            {
                HeapNode temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                MaxHeapify(arr, largest);
            }
        }

        public void BuildMaxHeap(List<HeapNode> arr)
        {
            int len = arr.Count;
            for (int i = (int)Math.Floor((double)len / 2) - 1; i >= 0; i--)
                MaxHeapify(arr, i);
        }

        public int ExtractMax(List<HeapNode> arr)
        {
            int len = arr.Count;
            HeapNode maxValue = arr[0];
            arr[0] = arr[len - 1];
            arr.RemoveAt(len - 1);
            MaxHeapify(arr, 0);
            return maxValue.key;
        }

        public void MinHeapify(List<HeapNode> arr, int i)
        {
            int left = Left(arr, i);
            int right = Right(arr, i);

            int heapSize = arr.Count;
            int smallest = i;

            if (left < heapSize && arr[left].key < arr[i].key)
                smallest = left;
            if (right < heapSize && arr[right].key < arr[smallest].key)
                smallest = right;

            if (smallest != i)
            {
                HeapNode temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
                MinHeapify(arr, smallest);
            }
        }

        public void BuildMinHeap(List<HeapNode> arr)
        {
            int len = arr.Count;
            for (int i = (int)Math.Floor((double)(len - 1) / 2); i >= 0; i--)
            {
                MinHeapify(arr, i);
            }
        }

        public int ExtractMin(List<HeapNode> arr)
        {
            int len = arr.Count;
            HeapNode result = arr[0];
            arr[0] = arr[len - 1];
            arr.RemoveAt(len - 1);
            MinHeapify(arr, 0);
            return result.key;
        }
    }
}
