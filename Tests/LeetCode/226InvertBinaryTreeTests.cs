using LeetCode._226_InvertBinaryTree;
using LeetCode.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.LeetCode;

[TestClass]
public class N226InvertBinaryTreeTests
{
    [TestMethod]
    public void FirstTest()
    {
        var tree = new TreeNode
        {
            val = 4,
            left = new()
            {
                val = 2,
                left = new(1),
                right = new(3)
            },
            right = new()
            {
                val = 7,
                left = new(6),
                right = new(9)
            }
        };
        var sol = new Solution();

        var res = sol.InvertTree(tree);

        Assert.IsNotNull(res);
        Assert.AreEqual(7, res.left.val);
        Assert.AreEqual(2, res.right.val);
        Assert.AreEqual(9, res.left.left.val);
        Assert.AreEqual(6, res.left.right.val);
        Assert.AreEqual(3, res.right.left.val);
        Assert.AreEqual(1, res.right.right.val);
    }

    [TestMethod]
    public void SecondTest()
    {
        TreeNode tree = null;
        var sol = new Solution();

        var res = sol.InvertTree(tree);

        Assert.IsNull(res);
    }
}
