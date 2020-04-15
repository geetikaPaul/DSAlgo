using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public static class NaryTreeTester
    {
        public static void Test()
        {
            NaryTree nt = new NaryTree();
            nt.InsertNode(1);
            nt.InsertNode(2, 1);
            nt.InsertNode(3, 1);
            nt.InsertNode(5, 2);
            nt.InsertNode(10, 5);
            nt.InsertNode(6, 2);
            nt.InsertNode(4, 1);
            nt.InsertNode(14, 4);
            nt.InsertNode(11, 6);
            nt.InsertNode(12, 6);
            nt.InsertNode(15, 12);

            //nt.PreOrderTraversal();
            //nt.PostOrderTraversal();
            //nt.LevelOrderTraversal();
            //Console.WriteLine(nt.SerializeLevel());

            //nt.SerializeUsingDictionary();
            nt.DeSerializeUsingDictionary("[ 1 [ 2 [ 5 [ 10 ] 6 [ 11 12 ] ] 3 4 [ 14 ] ] ]");
        }
    }
}
