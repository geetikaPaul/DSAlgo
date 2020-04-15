using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSumFunc(int[] nums)
        {
            int len = nums.Length;
            Dictionary<int, List<List<int>>> result = new Dictionary<int, List<List<int>>>();
            IList<IList<int>> r = new List<IList<int>>();

            for (int i = 0; i < len - 2; i++)
            {
                if (result.ContainsKey(nums[i]))
                    continue;
                int target = 0 - nums[i];
                Dictionary<int, int> pair = new Dictionary<int, int>();
                for (int j = i + 1; j < len; j++)
                {
                    int comp = target - nums[j];
                    for (int k = j + 1; k < len; k++)
                    {
                        if (nums[k] == comp)
                            pair.Add(nums[j], nums[k]);
                    }
                }


                foreach (var p in pair)
                {
                    List<int> l = new List<int>();
                    l.Add(nums[i]);
                    l.Add(p.Key);
                    l.Add(p.Value);
                    if (result.ContainsKey(nums[i]))
                    {
                        result[nums[i]].Add(l);
                    }
                    else
                        result.Add(nums[i], new List<List<int>>() { l });
                }

            }


            return r;
        }
    }
}
