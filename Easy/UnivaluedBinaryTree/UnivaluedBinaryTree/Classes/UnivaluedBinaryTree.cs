using System;
using System.Collections.Generic;
using System.Text;

namespace UnivaluedBinaryTree.Classes
{
    public class MyUnivaluedBinaryTree
    {
        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="root">TreeNode</param>
        /// <returns>bool</returns>
        public static bool IsUnivalTreeRecursive(TreeNode root)
        {
            if (root.left != null)
            {
                if (root.left.val != root.val || !IsUnivalTreeRecursive(root.left))
                    return false;
            }

            if (root.right != null)
            {
                if (root.right.val != root.val || !IsUnivalTreeRecursive(root.right))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Iterative
        /// </summary>
        /// <param name="root">TreeNode</param>
        /// <returns>bool</returns>
        public static bool IsUnivalTreeIterative(TreeNode root)
        {
            if (root.left == null && root.right == null) return true;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while(q.Count > 0)
            {
                var current = q.Dequeue();
                if(current.left != null)
                {
                    if (current.val != current.left.val)
                    {
                        return false;
                    }
                    q.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    if (current.val != current.right.val)
                    {
                        return false;
                    }
                    q.Enqueue(current.right);
                }
            }
            return true;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
  }
}
