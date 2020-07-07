using System;
using UnivaluedBinaryTree.Classes;
using Xunit;

namespace XUnitTestUnivaluedTree
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, true)]
        [InlineData(new int[] { 1, 2, 1 }, false)]
        [InlineData(new int[] { 3, 2, 1 }, false)]
        public void Test(int[] values, bool expected)
        {
            TreeNode tree = new TreeNode();
            tree.val = values[0];
            tree.left.val = values[1];
            tree.right.val = values[2];

            bool actual = MyUnivaluedBinaryTree.IsUnivalTreeRecursive(tree);
            Assert.Equal(expected, actual);
        }
    }
}
