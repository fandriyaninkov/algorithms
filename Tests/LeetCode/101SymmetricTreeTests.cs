using LeetCode._101_SymmetricTree;
using LeetCode.Common;

namespace Tests.LeetCode;

[TestClass]
public class N101SymmetricTreeTests
{
    [TestMethod]
    public void FirstTest()
    {
        var tree = new TreeNode
        {
            val = 1,
            left = new()
            {
                val = 2,
                left = new(3),
                right = new(4)
            },
            right = new()
            {
                val = 2,
                left = new(4),
                right = new(3)
            }
        };
        var sol = new Solution();

        var res = sol.IsSymmetric(tree);
        Assert.IsTrue(res);
    }

    [TestMethod]
    public void SecondTest()
    {
        var tree = new TreeNode
        {
            val = 1,
            left = new()
            {
                val = 2,
                right = new(3)
            },
            right = new()
            {
                val = 2,
                right = new(3)
            }
        };
        var sol = new Solution();

        var res = sol.IsSymmetric(tree);

        Assert.IsFalse(res);
    }

    [TestMethod]
    public void ThreeTest()
    {
        var tree = new TreeNode
        {
            val = 1,
            left = new(0)
        };
        var sol = new Solution();

        var res = sol.IsSymmetric(tree);

        Assert.IsFalse(res);
    }

    [TestMethod]
    public void FourTest()
    {
        var tree = new TreeNode
        {
            val = 1,
            left = new(2),
            right = new(3)
        };
        var sol = new Solution();

        var res = sol.IsSymmetric(tree);

        Assert.IsFalse(res);
    }

    [TestMethod]
    public void FiveTest()
    {
        var tree = new TreeNode
        {
            val = 1,
            left = new()
            {
                val = 2,
                right = new(3)
            },
            right = new()
            {
                val = 2,
                left = new(3)
            }
        };
        var sol = new Solution();

        var res = sol.IsSymmetric(tree);

        Assert.IsTrue(res);
    }

}
