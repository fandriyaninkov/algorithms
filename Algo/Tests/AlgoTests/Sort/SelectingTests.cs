using Algo.Sort;

namespace Tests.AlgoTests.Sort;

[TestClass]
public class SelectingTests
{
    [TestMethod]
    public void SelectingTest()
    {
        var array = new[] { 156, 141, 35, 94, 88, 61, 111 };
        var final = new[] { 35, 61, 88, 94, 111, 141, 156 };

        Selecting.Do(array);

        CollectionAssert.AreEqual(final, array);
    }

    [TestMethod]
    public void SelectingEmptyTest()
    {
        var array = Array.Empty<int>();
        Selecting.Do(array);

        Assert.AreEqual(0, array.Length);
    }
}
