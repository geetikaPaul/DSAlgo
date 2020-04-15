using DS.Problems;
using System;
using System.Collections.Generic;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            GCD g = new GCD();
            Console.WriteLine(g.GcdCalc(15, 25));
            /*DoublyEndedCircularQueue dcq = new DoublyEndedCircularQueue(5);
            dcq.EnqueueFront(1);
            dcq.EnqueueRear(3);
            dcq.EnqueueFront(2);
            dcq.EnqueueRear(5);
            dcq.EnqueueFront(20);
            dcq.EnqueueRear(10);
            bool status = true;
            int val;
            dcq.PrintQueue();
           
            int val = dcq.PeekFront(ref status);
            if (status)
                Console.WriteLine(val);
            status = true;
            val = dcq.PeekRear(ref status);
            if (status)
                Console.WriteLine(val);

            status = true;
            val = dcq.DequeueRear(ref status);
            if (status)
                Console.WriteLine(val);
            status = true;
            val = dcq.DequeueRear(ref status);
            if (status)
                Console.WriteLine(val);
            status = true;
            val = dcq.DequeueRear(ref status);
            if (status)
                Console.WriteLine(val);

            dcq.EnqueueFront(15);
            dcq.EnqueueFront(16);
            dcq.EnqueueFront(17);

            dcq.PrintQueue();

            dcq.EnqueueRear(19);*/

            /*status = true;
            val = dcq.DequeueFront(ref status);
            if (status)
                Console.WriteLine(val);
            status = true;
            val = dcq.DequeueFront(ref status);
            if (status)
                Console.WriteLine(val);*/


            // HappyNumber h = new HappyNumber();
            //h.IsHappy(79);
            /*for(int i=1;i<=100;i++)
                Console.WriteLine(h.IsHappy(i)?i.ToString():"");*/
            /* DisjointSetRankCompression d = new DisjointSetRankCompression();
             Subset[] subsets = new Subset[5] { new Subset(0, 0), new Subset(1, 0), new Subset(2, 0), new Subset(3, 0), new Subset(4, 0) };

             int[][] edges = new int[4][];
             edges[0] = new int[] { 0, 1 };
             edges[1] = new int[] { 2, 3 };
             edges[2] = new int[] { 1, 3 };
             edges[3] = new int[] { 4, 0 };

             foreach(var edge in edges)
             {
                 d.Union(subsets, edge[0], edge[1]);
             }*/

            /*CountCommunicatingServers c = new CountCommunicatingServers();
            int[][] input = new int[4][];
            input[0] = new int[] {1,1,0,0 };
            input[1] = new int[] { 0,0,1,0};
            input[2] = new int[] { 0,0,1,0};
            input[3] = new int[] { 0,0,0,1};
            Console.WriteLine(c.func(input));*/

            /*IList<IList<int>> rooms = new List<IList<int>>();
            rooms.Add(new List<int>() { 2});
            rooms.Add(new List<int>() );
            rooms.Add(new List<int>() { 1});
            KeysAndRooms kr = new KeysAndRooms();
            Console.WriteLine(kr.func(rooms));*/

            /*int n = 1;
            int[][] input = new int[0][];
            //input[0] = new int[] { 0,0 };
            input[1] = new int[] { 1,2 };
            input[2] = new int[] { 0,3 };
            input[3] = new int[] { 3,2 };
            input[4] = new int[] { 2,1 };
            int s = 0;
            int d = 0;
            AllPathsFromSourceToDestination t = new AllPathsFromSourceToDestination();
            Console.WriteLine(t.LeadsToDestination(n, input, s, d));*/

            char[][] input = new char[6][];

            SurroundedRegions sr = new SurroundedRegions();
            //test case 1
            /*input[0] = new char[] { 'X', 'X', 'X', 'X'};
            input[1] = new char[] { 'X', 'O', 'O', 'X'};
            input[2] = new char[] { 'X', 'X', 'O', 'X'};
            input[3] = new char[] { 'X', 'O', 'X', 'X'};

            sr.Solve(input);

            //test case 2
            input[0] = new char[] { 'X', 'O', 'X', 'X' };
            input[1] = new char[] { 'X', 'O', 'O', 'X' };
            input[2] = new char[] { 'X', 'X', 'O', 'X' };
            input[3] = new char[] { 'X', 'O', 'X', 'X' };

            sr.Solve(input);

            //test case 3
            input[0] = new char[] { 'X', 'X', 'X', 'X' };
            input[1] = new char[] { 'X', 'X', 'O', 'X' };
            input[2] = new char[] { 'X', 'X', 'O', 'X' };
            input[3] = new char[] { 'X', 'X', 'O', 'X' };

            sr.Solve(input);

            //test 4
            input[0] = new char[] { 'X', 'X', 'X', 'X' };
            input[1] = new char[] { 'X', 'X', 'O', 'O' };
            input[2] = new char[] { 'X', 'X', 'O', 'X' };
            input[3] = new char[] { 'X', 'X', 'X', 'X' };

            sr.Solve(input);

            input[0] = new char[] { 'X', 'X', 'X', 'X', 'O', 'X' };
            input[1] = new char[] { 'O', 'X', 'X', 'O', 'O', 'X' };
            input[2] = new char[] { 'X', 'O', 'X', 'O', 'O', 'O' };
            input[3] = new char[] { 'X', 'O', 'O', 'O', 'X', 'O' };
            input[4] = new char[] { 'O', 'O', 'X', 'X', 'O', 'X' };
            input[5] = new char[] { 'X', 'O', 'X', 'O', 'X', 'X' };

            sr.Solve(input);*/

            /*RedundantConnection rc = new RedundantConnection();
           int[][] edges = new int[10][];
            edges[0] = new int[2] { 9, 10 };
            edges[1] = new int[2] { 5, 8 };
            edges[2] = new int[2] { 2, 6 };
            edges[3] = new int[2] { 1, 5 };
            edges[4] = new int[2] { 3, 8 };
            edges[5] = new int[2] { 4, 9 };
            edges[6] = new int[2] { 8, 10 };
            edges[7] = new int[2] { 4, 10 };
            edges[8] = new int[2] { 6, 8 };
            edges[9] = new int[2] { 7, 9 };

            int[][] edges = new int[3][];
            edges[0] = new int[] { 1, 2 };
            edges[1] = new int[] { 1, 3 };
            edges[2] = new int[] { 2, 3 };
            rc.FindRedundantConnection(edges);*/

            /*TimeNeededToInform t = new TimeNeededToInform();
            t.NumOfMinutes(11, 4, new int[] { 5, 9, 6, 10, -1, 8, 9, 1, 9, 3, 4 }, new int[]{ 0, 213, 0, 253, 686, 170, 975, 0, 261, 309, 337 });*/

            FrogPositionAfterTSeconds f = new FrogPositionAfterTSeconds();
            /*int[][] edges = new int[2][];
            edges[0] = new int[2] { 2, 1 };
            edges[1] = new int[2] { 2, 3 };
            /*edges[2] = new int[2] { 4, 1 };
            edges[3] = new int[2] { 5, 1 };
            edges[4] = new int[2] { 6, 4 };
            edges[5] = new int[2] { 7, 1 };
            edges[6] = new int[2] { 8, 7 };
            f.FrogPosition(3, edges, 1, 2);*/

            /*DSUTester dst = new DSUTester();
            dst.Test();*/

            /*NumberOfIslands n = new NumberOfIslands();
            char[][] grid = new char[4][];
            grid[0] = new char[] { '1', '1', '1', '1', '0' };
            grid[1] = new char[] { '1', '1', '0', '1', '0' };
            grid[2] = new char[] { '1', '1', '0', '0', '0' };
            grid[3] = new char[] { '0', '0', '0', '1', '1' };
            n.NumIslands(grid);*/

            //PrimePalindrome pp = new PrimePalindrome();
            //pp.PalindromeGenerator(999);
            /*Console.WriteLine(pp.PrimePalindromeCalc(2));
            Console.WriteLine(pp.PrimePalindromeCalc(6));
            Console.WriteLine(pp.PrimePalindromeCalc(8));
            Console.WriteLine(pp.PrimePalindromeCalc(13));
            Console.WriteLine(pp.PrimePalindromeCalc(99));*/
            //Console.WriteLine(pp.PrimePalindromeCalc(10));


            //ReverseInteger r = new ReverseInteger();
            /*r.func(123);
            r.func(-123);
            r.func(120);*/
            //r.func(1534236469);

            /*NumberOfCandies n = new NumberOfCandies();
            n.func(20, 3);*/

            //CircularPermutation c = new CircularPermutation();
            //c.func(3,2);

            

            //NaryTreeTester.Test();
            //GraphTester.Test();
            /*MonkAndChamberOfSecrets t1 = new MonkAndChamberOfSecrets();
            t1.func();*/

            /*BinaryTree bt = new BinaryTree();
            bt.InsertNode( 1);
            bt.InsertNode( 2);
            bt.InsertNode( 3);
            bt.InsertNode( 4);
            bt.InsertNode( 5);
            bt.InsertNode( 6);
            bt.InsertNode(7);
            /*bt.InsertNode(8);
            bt.InsertNode(9);
            bt.InsertNode(10);
            bt.InsertNode(11);
            bt.InsertNode(12);
            bt.InsertNode(13);
            bt.InsertNode(14);
            bt.InsertNode(15);

            Console.WriteLine("Preorder traversal");
            bt.PreOrderTraversal();
            Console.WriteLine("Level order traversal");
            bt.LevelOrderTraversal();
            Console.WriteLine("Postorder traversal");
            bt.PostOrderTraversal();
            Console.WriteLine("Inorder traversal");
            bt.InOrderTraversal();

            /*Console.WriteLine("count of nodes: " + bt.CountNodes());
            Console.WriteLine("Height of the tree: " + bt.CalculatHeight());

            Console.WriteLine("Deepest Node: " +  (bt.DeepestNode()!=null? bt.DeepestNode().val.ToString():"Empty tree"));*/

            /*BTNode ElementNode = bt.SearchElement(4);
            if (ElementNode != null)
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");*/

            //Console.WriteLine("number of occurences: " + bt.NumberOfOccurencesOfElement(3));

            /*Console.Write("deepest Node of given element: ");
            BTNode ElementNode = bt.DeepestNodeOfElement(1);
            if (ElementNode != null)
                Console.WriteLine(ElementNode.val);
            else
                Console.WriteLine("not found");*/

            /*bt.DeleteElement(6);
            Console.WriteLine("Inorder traversal");
            bt.InOrderTraversal();*/

            //Console.WriteLine("Count of leaf nodes: " + bt.LeafNodesCountRec());

            //Console.WriteLine("print all ancestor");
            //bt.PrintAllAncestor(5);

            //bt.FindTilt();
            /*bt.DeleteElement(4);
            Console.WriteLine("left most node");
            BTNode res = bt.LeftMostNode();
            Console.WriteLine(res!=null? res.val.ToString() : "empty tree");

            bt.DeleteElement(15);
            Console.WriteLine("right most node");
             BTNode res = bt.RightMostNode();
            Console.WriteLine(res != null ? res.val.ToString() : "empty tree");

            //Console.WriteLine("leaf nodes");
            //bt.PrintLeafNodes();

            bt.DeleteElement(6);
            Console.WriteLine("flattened list");
            LinkedList<int> node = bt.FlattenTree();
            foreach (int i in node)
            {
                Console.WriteLine(i);
            }*/

            Console.Read();


            /*Stack s = new Stack();
            s.Push(10);
            s.Push(1);
            s.PrintStack();
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.TopElement());
            s.Push(11);
            Console.WriteLine(s.TopElement());
            s.PrintStack();
            Console.Read();*/

            /*Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(100);
            q.PrintQueue();
            Console.WriteLine(q.Dequeue());
            q.PrintQueue();
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.Read();*/

            /*LinkedList l = new LinkedList();
            l.Add(1);
            l.Add(3);
            l.Add(2);
            l.Add(4);
            l.Add(0);
            l.PrintList();
            Console.Read();*/


            /*BST bst = new BST();
            bst.insert(15);
            bst.insert(6);
            bst.insert(7);
            bst.insert(3);
            bst.insert(2);
            bst.insert(4);
            bst.insert(13);
            bst.insert(9);
            bst.insert(18);
            bst.insert(20);
            bst.insert(17);
            bst.inorderTraversal();
            Element element = bst.Search(4);
            if (element != null)
            {
                Console.WriteLine("found " + element.value.ToString());
            }
            else
            {
                Console.WriteLine("not found ");
            }

            element = bst.Search(10);
            if (element != null)
            {
                Console.WriteLine("found " + element.value.ToString());
            }
            else
            {
                Console.WriteLine("not found ");
            }

            Console.WriteLine(bst.TreeMinimum().value);
            Console.WriteLine(bst.TreeMaximum().value);

            Console.WriteLine(bst.SuccessorFinder(13).value);
            Console.WriteLine(bst.SuccessorFinder(15).value);

            Console.WriteLine(bst.PredecessorFinder(15).value);
            Console.WriteLine(bst.PredecessorFinder(17).value);

            bst.Delete(2);
           
            Console.WriteLine("After deletion of 2");
            bst.inorderTraversal();

            bst.Delete(3);

            Console.WriteLine("After deletion of 3");
            bst.inorderTraversal();

            bst.Delete(13);

            Console.WriteLine("After deletion of 13");
            bst.inorderTraversal();

            bst.Delete(15);

            Console.WriteLine("After deletion of 15");
            bst.inorderTraversal();*/

            //Heap heap = new Heap();
            //List<int> arrList = new List<int>() { 16, 4, 10, 14, 7, 1, 3, 2, 8, 9 };
            //int len = arrList.Count;
            //heap.MaxHeapify(arr, 1);
            //heap.BuildMaxHeap(arrList);
            //for (int i = 0; i < arrList.Count; i++)
            //    Console.Write(arrList[i] + " ");
            //Console.WriteLine("");

            //Console.WriteLine("Max element: " + heap.ExtractMax(arrList));

            //for (int i = 0; i < arrList.Count; i++)
            //    Console.Write(arrList[i] + " ");
            //Console.WriteLine("");
            //Console.WriteLine("Max element: " + heap.ExtractMax(arrList));

            //for (int i = 0; i < arrList.Count; i++)
            //    Console.Write(arrList[i] + " ");
            //Console.WriteLine("");
            //heap.DecreaseKey(arrList, 0, 5);
            //for (int i = 0; i < arrList.Count; i++)
            //    Console.Write(arrList[i] + " ");

            /*LastStoneWeight lastStoneWeight = new LastStoneWeight();
            Console.Write(lastStoneWeight.LastStoneWeightCalc(new [] {0}));*/

            /*Heap heap = new Heap();
            List<int> arrList = new List<int>() { 8, 5, 7, 4, 2, 6, 1 };
            int len = arrList.Count;
            //heap.MinHeapify(arrList, 1);
            heap.BuildMinHeap(arrList);
            for (int i = 0; i < arrList.Count; i++)
                Console.Write(arrList[i] + " ");
            Console.WriteLine("");

            Console.WriteLine("Min element: " + heap.ExtractMin(arrList));
            for (int i = 0; i < arrList.Count; i++)
                Console.Write(arrList[i] + " ");
            Console.WriteLine("");
            Console.WriteLine("Min element: " + heap.ExtractMin(arrList));
            for (int i = 0; i < arrList.Count; i++)
                Console.Write(arrList[i] + " ");
            Console.WriteLine("");
            Console.WriteLine("Min element: " + heap.ExtractMin(arrList));
            for (int i = 0; i < arrList.Count; i++)
                Console.Write(arrList[i] + " ");
            Console.WriteLine("");*/

        }
    }
}
