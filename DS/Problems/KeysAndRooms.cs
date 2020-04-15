using System;
using System.Collections.Generic;
using System.Linq;

namespace DS.Problems
{
    public class KeysAndRooms
    {
        public bool func(IList<IList<int>> rooms)
        {
            int len = rooms.ToList().Count;

            IList<bool> coveredRoom = new List<bool>();
            for (int i = 0; i < len; i++)
                coveredRoom.Add(false);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                int cur = queue.Dequeue();
                if (!coveredRoom[cur])
                {
                    coveredRoom[cur] = true;
                    foreach (var key in rooms[cur])
                        if (key != cur)
                            queue.Enqueue(key);
                }
            }

            if (coveredRoom.Contains(false))
                return false;

            return true;
        }
    }
}
