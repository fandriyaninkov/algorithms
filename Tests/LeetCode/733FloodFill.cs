using LeetCode._733_FloodFill;

namespace Tests.LeetCode;

[TestClass]
public class N733FloodFill
{
    [TestMethod]
    public void FirstTest()
    {
        var image = new int[][] { [1, 1, 1], [1, 1, 0], [1, 0, 1] };
        var expected = new int[][] { [2, 2, 2], [2, 2, 0], [2, 0, 1] };
        var sr = 1;
        var sc = 1;
        var color = 2;
        var sol = new Solution();

        var res = sol.FloodFill(image, sr, sc, color);
        CollectionAssert.AreEqual(expected, res);
    }

    [TestMethod]
    public void SecondTest()
    {
        var image = new int[][] { [0, 0, 0], [0, 0, 0] };
        var expected = new int[][] { [0, 0, 0], [0, 0, 0] };
        var sr = 0;
        var sc = 0;
        var color = 0;
        var sol = new Solution();

        var res = sol.FloodFill(image, sr, sc, color);
        CollectionAssert.AreEqual(expected, res);
    }
}
