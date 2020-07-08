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
            var left = new TreeNode(values[1]);
            var right = new TreeNode(values[2]);
            var root = new TreeNode(values[0], left, right);

            bool actual = MyUnivaluedBinaryTree.IsUnivalTreeRecursive(root);
            Assert.Equal(expected, actual);
        }
    }
}
