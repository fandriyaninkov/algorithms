using LeetCode._217_DuplicateElements;

namespace Tests.LeetCode;

[TestClass]
public class N217ContainsDuplicate
{
    [TestMethod]
    public void Example1Test()
    {
        var nums = new[] { 1, 2, 3, 1 };

        var res = Solution.ContainsDuplicate(nums);
        Assert.IsTrue(res);
    }

    [TestMethod]
    public void Example2Test()
    {
        var nums = new[] { 1, 2, 3, 4 };

        var res = Solution.ContainsDuplicate(nums);
        Assert.IsFalse(res);
    }

    [TestMethod]
    public void Example3Test()
    {
        var nums = new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        var res = Solution.ContainsDuplicate(nums);
        Assert.IsTrue(res);
    }
}
