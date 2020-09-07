using System;
using System.Collections.Generic;

namespace LAB_1___ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST");


            LAB_1___DataStructures.NoLinealStructures.Tree.MultipathTree<int> Tree = new LAB_1___DataStructures.NoLinealStructures.Tree.MultipathTree<int>();
            Tree.Grade = 3;
            Tree.Comparer = KeyComparison;

            int[] ar = {62,85,93,43,25,28,36,52,5,63,38,94,81,33,69,40,20,88,97,16};

            for (int i = 0; i < ar.Length; i++)
            {
                Tree.Insert(ar[i]);
            }

            List<int> TraversalTest = Tree.ToPostOrden();

            string inorden = "";
            for (int i = 0; i < TraversalTest.Count; i++)
            {
                inorden+=TraversalTest[i].ToString()+", ";
            }

            Console.WriteLine("\nInsertados: \n"+Tree.Count);


            Console.WriteLine("\nPostOrden: \n" + inorden);


            Console.ReadLine();
        }

        public static Comparison<int> KeyComparison = delegate (int x1, int x2)
        {
            if (x1 > x2) return 1;
            if (x2 > x1) return -1;
            return 0;
        };
    }
}
