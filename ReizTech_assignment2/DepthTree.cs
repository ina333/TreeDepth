using System;

namespace ReizTech_assignment2
{
    class DepthTree
    {
        
        static void Main(string[] args)
        {
            ///<summary>Tree Structure</summary>
            TreeNode<int> root = new TreeNode<int>(1);
            TreeNode<int> c1 = new TreeNode<int>(2);
            TreeNode<int> c2 = new TreeNode<int>(2);
            TreeNode<int> c3 = new TreeNode<int>(3);
            TreeNode<int> c4 = new TreeNode<int>(3);
            TreeNode<int> c5 = new TreeNode<int>(3);
            TreeNode<int> c6 = new TreeNode<int>(3);
            TreeNode<int> c7 = new TreeNode<int>(4);
            TreeNode<int> c8 = new TreeNode<int>(4);
            TreeNode<int> c9 = new TreeNode<int>(4);
            TreeNode<int> c10 = new TreeNode<int>(5);

            root.setChild(c1); //setting the children of the root which is 1
            root.setChild(c2);

            //setting the other children to other nodes
            c1.setChild(c3);

            c2.setChild(c4);
            c2.setChild(c5);
            c2.setChild(c6);

            c4.setChild(c7);

            c5.setChild(c8);
            c5.setChild(c9);

            c8.setChild(c10);

            // Calculating depth of the tree by calling the method and printing the answer
            Console.WriteLine("MAX DEPTH OF THE TREE IS : " +root.maxDepth(root));
        }

    }
}
