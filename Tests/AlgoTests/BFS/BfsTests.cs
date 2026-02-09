using Algo.BFS;

namespace Tests.AlgoTests.BFS;

[TestClass]
public class BfsTests
{
    [TestMethod]
    public void Test()
    {
        var item = new Bfs();
        var res = item.Do();

        Assert.IsNotNull(res);
        Assert.AreEqual("Amelia", res);
    }
}
