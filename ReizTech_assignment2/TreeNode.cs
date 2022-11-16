using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_assignment2
{
    public class TreeNode<T>
    {
        //declaring a list because we have a non-binary tree and one of the parent have more than 2 child
        private List<TreeNode<T>> children = new List<TreeNode<T>>();  
        private T data = default(T);
        public TreeNode(T data)
        {
            this.data = data;
        }
        public List<TreeNode<T>> getChildren()
        {
            return children;
        }

        public void setChild(TreeNode<T> children)
        {
            this.children.Add(children);
        }

        public int maxDepth(TreeNode<T> root) 
        {
            if (root == null) return 0;
            int h = 0;

            foreach (TreeNode<T> n in root.getChildren())
            {
                h = Math.Max(h, maxDepth(n)); 
            }
            return h + 1;  //widht=height+1
        }
     
    }
}
