using LeetCode._200_NumberOfIslands;

namespace Tests.LeetCode;

[TestClass]
public class N200NumberOfIslands
{
    [TestMethod]
    public void FirstTest()
    {
        var grid = new char[][] { ['1', '1', '1', '1', '0'], ['1', '1', '0', '1', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '0', '0', '0'] };
        var expected = 1;
        var sol = new Solution();

        var count = sol.NumIslands(grid);
        Assert.AreEqual(expected, count);
    }

    [TestMethod]
    public void SecondTest()
    {
        var grid = new char[][] { ['1', '1', '0', '0', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '1', '0', '0'], ['0', '0', '0', '1', '1'] };
        var expected = 3;
        var sol = new Solution();

        var count = sol.NumIslands(grid);
        Assert.AreEqual(expected, count);
    }
}
