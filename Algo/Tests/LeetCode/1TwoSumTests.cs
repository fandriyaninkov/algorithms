using LeetCode._1_TwoSum;

namespace Tests.LeetCode;

[TestClass]
public class N1TwoSumTests
{
    [TestMethod]
    public void FirstTest()
    {
        var input = new[] { 2, 7, 11, 15 };
        var target = 9;
        var final = new[] { 0, 1 };

        var res = Solution.TwoSum(input, target);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void SameElementsTest()
    {
        var input = new[] { 3, 3 };
        var target = 6;
        var final = new[] { 0, 1 };

        var res = Solution.TwoSum(input, target);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void NegativeElementsTest()
    {
        var input = new[] { -3, 4, 3, 90 };
        var target = 0;
        var final = new[] { 0, 2 };

        var res = Solution.TwoSum(input, target);
        CollectionAssert.AreEqual(final, res);
    }
}
