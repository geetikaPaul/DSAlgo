using System;
using System.Collections.Generic;
using System.Text;
using static DS.HeapWithDuplicates;

namespace DS.Problems
{
    public class HE_LittleMonkAndWilliamson
    {
        List<int> _arrMaxHeap = new List<int>();
        List<int> _arrMinHeap = new List<int>();
        Heap _heap = new Heap();
        Dictionary<int, int> _arrCnt = new Dictionary<int, int>();

        public void Input()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            while(q>0)
            {
                string query = Console.ReadLine();
                if(query.Contains("Push"))
                {
                    Push(Convert.ToInt32(query.Split(' ')[1]));
                }
                else if(query.Equals("Diff"))
                {
                    Console.WriteLine(MaxMinDiff());
                }
                else if(query.Equals("CountHigh"))
                {
                    Console.WriteLine(CountHigh());
                }
                else if (query.Equals("CountLow"))
                {
                    Console.WriteLine(CountLow());
                }
                q--;
            }
            Console.Read();
        }
        private void Push(int n)
        {
            if (_arrCnt.ContainsKey(n))
            {
                _arrCnt[n]++;
            }
            else
            {
                _arrCnt.Add(n, 1);
                _arrMaxHeap.Add(n);
                _arrMinHeap.Add(n);
                _heap.BuildMaxHeap(_arrMaxHeap);
                _heap.BuildMinHeap(_arrMinHeap);
            }
        }

        private int MaxMinDiff()
        {
            if(_arrMaxHeap.Count>0)
            {
                int max = _arrMaxHeap[0];
                int min = _arrMinHeap[0];

                if (max == min)
                {

                    _arrCnt[_arrMinHeap[0]]--;                   
                    
                }

                else
                {
                    _arrCnt[_arrMaxHeap[0]]--;
                    _arrCnt[_arrMinHeap[0]]--;
                   
                }

                if (_arrCnt[_arrMaxHeap[0]] == 0)
                    _heap.ExtractMax(_arrMaxHeap);
                if (_arrCnt[_arrMinHeap[0]] == 0)
                    _heap.ExtractMin(_arrMinHeap);

                _arrMaxHeap.Remove(min);
                _arrMinHeap.Remove(max);

                return max-min;
            }

            return -1;
        }

        private int CountHigh()
        {
            if (_arrMaxHeap.Count > 0)
                return _arrCnt[_arrMaxHeap[0]];
            return -1;
        }

        private int CountLow()
        {
            if (_arrMinHeap.Count > 0)
                return _arrCnt[_arrMinHeap[0]];
            return -1;
        }
    }
}
