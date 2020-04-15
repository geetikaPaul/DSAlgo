using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS
{
    public class NaryNode
    {
        public int val { get; set; }
        public IList<NaryNode> children { get; set; }

        public NaryNode(int v)
        {
            val = v;
            children = null;
        }

        public NaryNode(int v, IList<NaryNode> n)
        {
            val = v;
            children = n;
        }
    }

    public class NaryNodeWithLevel
    {
        public NaryNode node { get; set; }
        public int level { get; set; }
        
        public NaryNodeWithLevel(NaryNode n, int l)
        {
            node = n;
            level = l;
        }
    }
    public class NaryTree
    {
        public NaryNode root { get; set; }
        public NaryTree()
        {
            root = null;
        }
        public void PreOrderTraversal()
        {
            PreOrderTraversalRecur(root);
        }

        private void PreOrderTraversalRecur(NaryNode root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.val);
            if(root.children!=null)
            {
                foreach (var child in root.children)
                {
                    PreOrderTraversalRecur(child);
                }
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversalRecur(root);
        }

        private void PostOrderTraversalRecur(NaryNode root)
        {
            if (root == null)
                return;
            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    PostOrderTraversalRecur(child);
                }
            }
            Console.WriteLine(root.val);
        }

        public void InsertNode(int value, int parentVal = -1)
        {
            InsertNode(root, value, parentVal);
        }

        private void InsertNode(NaryNode root, int value, int parentValue = -1)
        {
            if (root == null)
            {
                if (parentValue == -1)
                    this.root = new NaryNode(value);
                return;
            }

            if (root.val == parentValue)
            {
                if (root.children == null)
                    root.children = new List<NaryNode>() { new NaryNode(value) };
                else
                    root.children.Add(new NaryNode(value));
                return;
            }
            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    if (child != null)
                        InsertNode(child, value, parentValue);
                }
            }
        }
        private void DeleteNode(int value)
        {
          //  DeleteNode(root, value);
        }

        public void LevelOrderTraversal()
        {
            LevelOrderTraversal(root);
        }

        private void LevelOrderTraversal(NaryNode root)
        {

            if (root == null)
                return;

            Queue<NaryNode> queue = new Queue<NaryNode>();
            queue.Enqueue(root);

            while(queue.Count>0)
            {
                NaryNode cur = queue.Dequeue();
                Console.WriteLine(cur.val);

                if (cur.children != null)
                    foreach (var child in cur.children)
                    {
                        if (child != null)
                            queue.Enqueue(child);
                    }
            }
        }
        
        public string Serialize()
        {
            if (root == null)
                return "[]";
            string result = String.Empty;
            Serialize(new NaryNodeWithLevel(root, 0), -1 , ref result);
            return result;
        }

        private void Serialize(NaryNodeWithLevel root, int curLevel, ref string result)
        {
            if (root == null)
                return;
            if(root.level != curLevel)
                result = string.Concat(result, "[",root.node.val);
            else
                result = string.Concat(result, " ", root.node.val);

            if (root.node.children != null)
            {
                curLevel += 1;
                foreach (var child in root.node.children)
                {
                    if (child != null)
                    {
                        Serialize(new NaryNodeWithLevel(child, root.level+1), curLevel, ref result);
                    }
                }
            }
             result = string.Concat(result, "]");

        }

        public string SerializeLevel()
        {
            return SerializeLevel(root);
        }
        private string SerializeLevel(NaryNode root)
        {
            if (root == null)
                return "null";
            
            List<string> resultList = new List<string>();

            Queue<NaryNodeWithLevel> queue = new Queue<NaryNodeWithLevel>();
            queue.Enqueue(new NaryNodeWithLevel(root, 0));
            queue.Enqueue(new NaryNodeWithLevel(null, 0));

            int currentLevel = 0;

            while (queue.Count > 0)
            {
                
                NaryNodeWithLevel cur = queue.Dequeue();
                if(currentLevel<cur.level)
                {
                    currentLevel = cur.level;
                    queue.Enqueue(new NaryNodeWithLevel(null, currentLevel));
                }
                if(cur.node==null)
                {
                    // result = string.Concat(result, " null");
                    resultList.Add("null");
                    continue;
                }
                //result = string.Concat(result, " ", cur.node.val);
                resultList.Add(cur.node.val.ToString());
                if (cur.node.children != null)
                {
                    foreach (var child in cur.node.children)
                    {
                        if (child != null)
                        {
                            queue.Enqueue(new NaryNodeWithLevel(child, cur.level+1));
                        }
                    }
                }
                else
                    queue.Enqueue(new NaryNodeWithLevel(null, cur.level + 1));
            }

            for (int i = resultList.Count - 1; i >= 0; i--)
            {
                if (resultList[i] == "null") resultList.RemoveAt(i);
                else break;
            }

            return string.Join(" ", resultList);
        }

        public string SerializeUsingDictionary()
        {
            string result = string.Empty;
            Dictionary<int, IList<int>> dict = new Dictionary<int, IList<int>>();
            SerializeUsingDictionary(root, ref dict);

            result = string.Concat("[", root.val);
            GenerateSerializedString(root.val, dict, ref result);
            result = string.Concat(result,"]");
            return result;
        }

        private void GenerateSerializedString(int key, Dictionary<int, IList<int>> dict, ref string result)
        {
            if (!dict.ContainsKey(key))
                return;

            result = string.Concat(result, "[");
            foreach(var entry in dict[key])
            {
                result = string.Concat(result, entry, " ");
                GenerateSerializedString(entry, dict, ref result);
            }
            result = string.Concat(result, "]");
        }
        private void SerializeUsingDictionary(NaryNode root, ref Dictionary<int, IList<int>> dict)
        {
            if (root == null)
                return;

            if(root.children!=null)
            {
                foreach(var child in root.children)
                {
                    if(child!=null)
                    {
                        if(dict.ContainsKey(root.val))
                        {
                            dict[root.val].Add(child.val);
                        }
                        else
                        {
                            dict[root.val] = new List<int>() { child.val };
                        }
                    }
                    SerializeUsingDictionary(child, ref dict);
                }
            }
        }

        public NaryTree DeSerializeUsingDictionary(string tree)
        {
            NaryTree result = new NaryTree();
            Dictionary<int, IList<int>> dict = new Dictionary<int, IList<int>>();
            DeSerializeUsingDictionary(tree, ref dict);

            result.InsertNode(dict.Keys.First());
            foreach(var entry in dict)
            {
                if (entry.Value != null)
                {
                    IEnumerable<int> reversed = entry.Value.Reverse();
                    foreach (var node in reversed)
                    {
                        result.InsertNode(node, entry.Key);
                    }
                }
            }
            return result;
        }
        

        private void DeSerializeUsingDictionary(string tree, ref Dictionary<int, IList<int>> dict)
        {
            if (root == null)
                return;

            Stack<string> stack = new Stack<string>();
            string[] words = tree.Split(' ');
            
            foreach(var word in words)
            {
                if (word.Equals("]"))
                {
                    List<int> children = new List<int>();
                    while (!stack.Peek().Equals("["))
                        children.Add(Convert.ToInt32(stack.Pop()));
                    stack.Pop();
                    if (stack.Count > 0)
                    {
                        int parent = Convert.ToInt32(stack.Peek());
                        dict[parent] = children;
                    }
                }
                else if (word.Equals("["))
                    stack.Push(word);
                else
                {
                    int parent = Convert.ToInt32(word);
                    if (!dict.ContainsKey(parent))
                        dict[parent] = null;
                    stack.Push(word);
                }
            }
        }
    }
}
