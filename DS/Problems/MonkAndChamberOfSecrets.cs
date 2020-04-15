using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class MonkAndChamberOfSecrets
    {
        public class NodeMonkAndChamberOfSecrets
        {
            public int value { get; set; }
            public int index { get; set; }
        }
        public void func()
        {
            string[] line1 = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(line1[0]);
            int x = Convert.ToInt32(line1[1]);

            string[] line2 = Console.ReadLine().Split(' ');
            Queue<NodeMonkAndChamberOfSecrets> spiders = new Queue<NodeMonkAndChamberOfSecrets>();

            int[] spiderArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                spiders.Enqueue(new NodeMonkAndChamberOfSecrets() { value = Convert.ToInt32(line2[i]), index = i+1 });
                spiderArray[i] = Convert.ToInt32(line2[i]);
            }

            for(int i=0;i<x;i++)
            {
                int max = -1;
                Queue<NodeMonkAndChamberOfSecrets> temp = new Queue<NodeMonkAndChamberOfSecrets>();
                int lim = 0;
                if(spiders.Count > 0)
                {
                    NodeMonkAndChamberOfSecrets power = spiders.Dequeue();
                    max = power.index;
                    temp.Enqueue(power);
                }
                while (spiders.Count > 0 && lim<x-1)
                {
                    NodeMonkAndChamberOfSecrets power = spiders.Dequeue();
                    if (power.value > spiderArray[max-1])
                        max = power.index;
                    temp.Enqueue(power);
                    lim++;
                }
                Console.Write(max + " ");

                while(temp.Count>0)
                {
                    NodeMonkAndChamberOfSecrets power = temp.Dequeue();
                    if (power.index != max)
                    {
                        spiders.Enqueue(new NodeMonkAndChamberOfSecrets() { value = power.value - 1 > 0 ? power.value - 1 : 0, index = power.index });
                        spiderArray[power.index - 1] = spiderArray[power.index - 1] - 1 > 0 ? spiderArray[power.index - 1] - 1 : 0;
                    }
                   }
            }
        }
    }
}
