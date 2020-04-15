using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class LittleMonkAndRoot
    {
        public class HeapLocal
        {
            public int Left(List<double> arr, int i)
            {
                return 2 * i + 1;
            }
            public int Right(List<double> arr, int i)
            {
                return 2 * i + 2;
            }
            public void MaxHeapify(List<double> arr, int i)
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
                    double temp = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = temp;
                    MaxHeapify(arr, largest);
                }
            }

            public void BuildMaxHeap(List<double> arr)
            {
                int len = arr.Count;
                for (int i = (int)Math.Floor((double)len / 2) - 1; i >= 0; i--)
                    MaxHeapify(arr, i);
            }
            
            public void DecreaseKey(List<double> arr, int key, double newValue)
            {
                if (arr[key] < newValue)
                    return;
                arr[key] = newValue;
                MaxHeapify(arr, key);
            }
           
        }
        public void func()
        {
            String[] line1 = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(line1[0]);
            int k = Convert.ToInt32(line1[1]);

            String[] line2 = Console.ReadLine().Split(' ');
            List<double> _runsPerInning = new List<double>();

            double initialAvg = 0.0;

            for (int i = 0; i < n; i++)
            {
                int run = Convert.ToInt32(line2[i]);
                _runsPerInning.Add(run);
                initialAvg += run;
            }

            HeapLocal heap = new HeapLocal();
            heap.BuildMaxHeap(_runsPerInning);

            double finalAvg = initialAvg;

            while(k>0)
            {
                double reduceTo = Math.Ceiling(_runsPerInning[0] / 3.0);
                finalAvg -= _runsPerInning[0];
                finalAvg += reduceTo;
                heap.DecreaseKey(_runsPerInning, 0, reduceTo);
                k--;
            }

            initialAvg /= n;
            finalAvg /= n;

            Console.WriteLine(String.Format("{0:0.000000}", initialAvg) + " " + String.Format("{0:0.000000}", finalAvg));
            
        }

    }
}
