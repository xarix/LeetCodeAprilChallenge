using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day11
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            return Math.Max(Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)), (Height(root.left) + Height(root.right)));
        }

        public int Height(TreeNode root)
        {
            if (root != null)
            {
                return 1 + Math.Max(Height(root.left), Height(root.right));
            }
            return 0;
        }

    }
}
