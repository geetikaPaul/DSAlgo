using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class BTNode
    {
        public int val { get; set; }
        public BTNode left { get; set; }
        public BTNode right { get; set; }

        public BTNode(int value)
        {
            val = value;
            left = null;
            right = null;
        }
    }
    public class BinaryTree
    {
        public BTNode root { get; set; }

        public BinaryTree()
        {
            root = null;
        }

        // level order insertion
        public void InsertNode( int val)
        {
           if(root == null)
            {
                root = new BTNode(val);
                return;
            }

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                BTNode cur = queue.Dequeue();
                if(cur.left == null)
                {
                    cur.left = new BTNode(val);
                    break;
                }
                else
                {
                    queue.Enqueue(cur.left);
                }
                if(cur.right == null)
                {
                    cur.right = new BTNode(val);
                    break;
                }
                else
                {
                    queue.Enqueue(cur.right);
                }
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }
        private void PreOrderTraversal(BTNode root) 
        {
            if (root == null)
                return;
            Console.WriteLine(root.val);
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
        }

        public void LevelOrderTraversal()
        {
            LevelOrderTraversal(root);
        }

        private void LevelOrderTraversal(BTNode root)
        {
            if (root == null)
                return;

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                BTNode cur = queue.Dequeue();
                if (cur != null)
                {
                    Console.WriteLine(cur.val);
                    queue.Enqueue(cur.left);
                    queue.Enqueue(cur.right);
                }
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }

        private void PostOrderTraversal(BTNode root)
        {
            if (root == null)
                return;
            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            Console.WriteLine(root.val);
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

        private void InOrderTraversal(BTNode root)
        {
            if (root == null)
                return;
            InOrderTraversal(root.left);
            Console.WriteLine(root.val);
            InOrderTraversal(root.right);
        }

        public int CountNodes()
        {
            return CountNodes(root);
        }

        private int CountNodes(BTNode root)
        {
            if (root == null)
             return 0;

            int count = 0;

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                BTNode cur = queue.Dequeue();
                
                if( cur!=null )
                {
                    count += 1;
                    queue.Enqueue(cur.left);                 
                    queue.Enqueue(cur.right);
                }
            }

            return count;
        }

        public int CalculatHeight()
        {
            //return CalculateHeightRecursive(root);
            return CalculateHeightIteratively(root);
        }

        private int CalculateHeightRecursive(BTNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(CalculateHeightRecursive(root.left), CalculateHeightRecursive(root.right)) + 1;
        }

        public class BTNodeCount
        {
            public BTNode node { get; set; }
            public int count { get; set; }

            public BTNodeCount(BTNode node, int cnt)
            {
                this.node = node;
                count = cnt;
            }
        }
        private int CalculateHeightIteratively(BTNode root)
        {
            
            if (root == null)
                return 0;
            Queue<BTNodeCount> queue = new Queue<BTNodeCount>();
            int height = 0;
            queue.Enqueue(new BTNodeCount(root,1));
            while(queue.Count>0)
            {
                BTNodeCount cur = queue.Dequeue();
                if (cur.count > height)
                    height = cur.count;
                if(cur.node.left!=null)
                { 
                    queue.Enqueue(new BTNodeCount(cur.node.left, cur.count+1));
                }
                if (cur.node.right != null)
                {
                    queue.Enqueue(new BTNodeCount(cur.node.right, cur.count + 1));
                }

            }
            return height;
        }

        public BTNode DeepestNode()
        {
            return DeepestNode(root);
        }

        private BTNode DeepestNode(BTNode root)
        {
            if (root == null)
                return null;
            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            BTNode cur = root;
            while(queue.Count>0)
            {
                cur = queue.Dequeue();
                if (cur.left != null)
                    queue.Enqueue(cur.left);
                if (cur.right != null)
                    queue.Enqueue(cur.right);
            }

            return cur;
        }

        public BTNode SearchElement(int value)
        {
            return SearchElementIter(root, value);
        }

        private BTNode SearchElement(BTNode root, int value)
        {
            if (root == null)
                return null;

            if (root.val == value)
                return root;
            BTNode temp = SearchElement(root.left, value);
            if (temp != null)
                return temp ;
            temp = SearchElement(root.right, value);
            if (temp != null)
                return temp;
            
            return temp;
        }

        private BTNode SearchElementIter(BTNode root, int value)
        {
            if (root == null)
                return null;

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);

            while(queue.Count>0)
            {
                BTNode cur = queue.Dequeue();
                if (cur != null && cur.val == value)
                    return cur;
                if(cur!=null && cur.left!=null)
                    queue.Enqueue(cur.left);
                if (cur != null && cur.right != null)
                    queue.Enqueue(cur.right);
            }

            return null;
        }

        public int NumberOfOccurencesOfElement(int value)
        {
            int count = 0;
            NumberOfOccurencesOfElement(root, value, ref count);
            return count;
        }

        private void NumberOfOccurencesOfElement(BTNode root, int value, ref int count)
        {
            if (root == null)
                return;

            if (root.val == value)
                count += 1;
            NumberOfOccurencesOfElement(root.left, value, ref count);
            NumberOfOccurencesOfElement(root.right, value, ref count);
        }

        public BTNode DeepestNodeOfElement(int value)
        {
            return DeepestNodeOfElement(root, value);
        }

        private BTNode DeepestNodeOfElement(BTNode root, int value)
        {
            if (root == null)
                return null;

            BTNode findValue = SearchElement(root, value);
            BTNode deepestNodeValue = DeepestNode(findValue);

            return deepestNodeValue;
        }

        public void DeleteElement(int value)
        {
            if (root == null)
                return;

            BTNode findValue = SearchElement(root, value);
            BTNode deepestNodeValue = DeepestNode(findValue);

            DeleteElement(ref findValue, ref deepestNodeValue);
        }
        private void DeleteElement( ref BTNode cur, ref BTNode deepestNode)
        {
            cur.val = deepestNode.val;

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                BTNode current = queue.Dequeue();
                if (current != null)
                {
                    if (current.left != null && current.left.val == cur.val && current.left.left == null && current.left.right == null)
                    {
                        current.left = null;
                        return;
                    }

                    if (current.right != null && current.right.val == cur.val && current.right.left == null && current.right.right == null)
                    {
                        current.right = null;
                        return;
                    }

                    if (current.left == null && current.right == null && current.val == cur.val && current == root)
                    {
                        root = null;
                        return;
                    }

                    queue.Enqueue(current.left);
                    queue.Enqueue(current.right);
                }
            }
        }

        public int LeafNodesCount()
        {
            return LeafNodesCount(root);
        }

        private int LeafNodesCount(BTNode root)
        {
            if (root == null)
                return 0;

            int count = 0;
            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                BTNode current = queue.Dequeue();
                if(current!=null)
                {
                    if (current.left == null && current.right == null)
                        count += 1;
                    else
                    {
                        queue.Enqueue(current.left);
                        queue.Enqueue(current.right);
                    }
                }
            }

            return count;
        }

        public int LeafNodesCountRec()
        {
            int count = 0;
            LeafNodesCountRec(root, ref count);
            return count;
        }
        private void LeafNodesCountRec(BTNode root, ref int count)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
                count += 1;
            LeafNodesCountRec(root.left, ref count);
            LeafNodesCountRec(root.right, ref count);
        }

        public void PrintAllAncestor(int value)
        {
            PrintAllAncestor(root, value);
        }

        private Boolean PrintAllAncestor(BTNode root, int value)
        {
            if (root == null)
                return false;

            /*if((root.left != null && root.left.val == value) ||
               (root.right != null && root.right.val == value) || 
               PrintAllAncestor(root.left, value) ||
               PrintAllAncestor(root.right, value))
            {
                Console.Write(root.val + " > ");
                return true;
            }*/

            if (root.val == value)
                return true;

            Boolean temp = PrintAllAncestor(root.left, value);
            if (temp)
            {
                Console.Write(root.val + " > ");
                return true;
            }
            temp = PrintAllAncestor(root.right, value);
            if (temp)
            {
                Console.Write(root.val + " > ");
                return true;
            }

            return temp;
        }

        public int FindTilt()
        {
            return FindTilt(root);
        }
        private int FindTilt(BTNode root)
        {
            if (root == null)
                return 0;

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);

            int tilt = 0;

            while (queue.Count > 0)
            {
                BTNode cur = queue.Dequeue();
                if (cur != null)
                {
                    if (cur.left != null)
                    {
                        if (cur.right != null)
                        {
                            tilt += Math.Abs(cur.right.val - cur.left.val);
                            queue.Enqueue(cur.left);
                            queue.Enqueue(cur.right);
                        }

                        else
                        {
                            tilt += cur.left.val;
                            queue.Enqueue(cur.left);
                        }
                    }
                    else
                    {
                        if (cur.right != null)
                        {
                            tilt += cur.right.val;
                            queue.Enqueue(cur.right);
                        }

                    }
                }
            }

            return tilt;
        }

        public BTNode LeftMostNode()
        {
            BTNode leftmostnode = null;
            Queue<BTNode> path = new Queue<BTNode>();
             LeftMostNode(root, ref leftmostnode, ref path);
            while (path.Count > 0)
                Console.WriteLine(path.Dequeue().val);
            return leftmostnode;
        }

        private bool LeftMostNode(BTNode root, ref BTNode leftmostnode, ref Queue<BTNode> path)
        {
            if (root == null)
                return false;

            path.Enqueue(root);
            if(root.left == null && root.right == null)
            {
                leftmostnode = root;
                return true;
            }
            bool temp = LeftMostNode(root.left, ref leftmostnode, ref path);
            if (temp)
                return true;
            temp = LeftMostNode(root.right, ref leftmostnode, ref path);
            if (temp)
                return true;

            return false;
        }

        public BTNode RightMostNode()
        {
            BTNode rightmostnode = null;
            Stack<BTNode> path = new Stack<BTNode>();
            RightMostNode(root, ref rightmostnode, ref path);
            while (path.Count > 0)
                Console.WriteLine(path.Pop().val);
            return rightmostnode;
        }

        private bool RightMostNode(BTNode root, ref BTNode rightmostnode, ref Stack<BTNode> path)
        {
            if (root == null)
                return false;

            path.Push(root);
            if (root.left == null && root.right == null)
            {
                rightmostnode = root;
                return true;
            }

            bool temp = RightMostNode(root.right, ref rightmostnode, ref path);
            if (temp)
                return true;
             
            temp = RightMostNode(root.left, ref rightmostnode, ref path);
            if (temp)
                return true;

            return false;
        }

        public void PrintLeafNodes()
        {
            PrintLeafNodes(root);
        }

        private void PrintLeafNodes(BTNode root)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
            {
                Console.WriteLine(root.val);
                return;
            }
            PrintLeafNodes(root.left);
            PrintLeafNodes(root.right);
        }

        public LinkedList<int> FlattenTree()
        {
            LinkedList<int> flattenedList = new LinkedList<int>();
            FlattenTree(root, ref flattenedList);
            return flattenedList;
        }
        private void FlattenTree(BTNode root, ref LinkedList<int> flattenedList)
        {
            if (root == null)
                return;

            flattenedList.AddLast(root.val);
            FlattenTree(root.left, ref flattenedList);
            FlattenTree(root.right, ref flattenedList);
        }

        private BTNode FlattenTreeInPlace(BTNode root)
        {
            if (root == null)
                return null;

            if (root.left == null && root.right == null)
                return root;


            BTNode leftNode = FlattenTreeInPlace(root.left);
            BTNode rightNode = FlattenTreeInPlace(root.right);

            if (leftNode != null)
            {
                leftNode.right = root.right;

                root.right = root.left;
                root.left = null;
            }
            return rightNode == null ? leftNode : rightNode;

        }
    }
}
