using LeetCode._104_MaxDepthInBinaryTree;

namespace Tests.LeetCode;

[TestClass]
public class N104MaxDepthInBinaryTree
{
    [TestMethod]
    public void FirstTest()
    {
        var tree = new TreeNode
        {
            val = 3,
            left = new TreeNode(9),
            right = new TreeNode
            {
                val = 20,
                left = new TreeNode(15),
                right = new TreeNode(7)
            }
        };
        var expected = 3;
        var sol = new Solution();

        var count = sol.MaxDepth(tree);
        Assert.AreEqual(expected, count);
    }

    [TestMethod]
    public void SecondTest()
    {
        var tree = new TreeNode(1, right: new TreeNode(2));
        var expected = 2;
        var sol = new Solution();

        var count = sol.MaxDepth(tree);
        Assert.AreEqual(expected, count);
    }

    [TestMethod]
    public void ThreeTest()
    {
        TreeNode tree = null;
        var expected = 0;
        var sol = new Solution();

        var count = sol.MaxDepth(tree);
        Assert.AreEqual(expected, count);
    }
}
