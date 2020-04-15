using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class LittleMonkAndVirat
    {
        
        public void Input()
        {
          List<int> _runs = new List<int>();
         Heap _heap = new Heap();
        int n = Convert.ToInt32(Console.ReadLine());

            int[][] runsArray = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                string[] runs = Console.ReadLine().Split(' ');
                runsArray[i] = new int[n];
                for (int j = 0; j < n; j++)
                    runsArray[i][j] = Convert.ToInt32(runs[j]);
            }

            for(int i=0;i<n; i++)
            {
                _runs.Add(runsArray[0][i] + runsArray[1][i] + runsArray[2][i]);
            }

            _heap.BuildMinHeap(_runs);

            int q = Convert.ToInt32(Console.ReadLine());
            while(q>0)
            {

                q--;
                int k = Convert.ToInt32(Console.ReadLine());
                if (k > _runs.Count)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                List<int> deletedRuns = new List<int>();
                while (k > 1)
                {
                    deletedRuns.Add(_heap.ExtractMin(_runs));
                    k--;
                }
                Console.WriteLine(_heap.ExtractMin(_runs));
                _runs.AddRange(deletedRuns);
                _heap.BuildMinHeap(_runs);
            }

        }        

    }
}
