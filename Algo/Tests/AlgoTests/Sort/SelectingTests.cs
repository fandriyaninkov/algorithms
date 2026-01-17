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

    [TestMethod]
    public void SingleElementTest()
    {
        var array = new[] { 42 };
        var final = new[] { 42 };

        Selecting.Do(array);
        CollectionAssert.AreEqual(final, array);
    }

    [TestMethod]
    public void SortTest()
    {
        var array = new[] { 3, 6, 9, 45, 75 };
        var final = new[] { 3, 6, 9, 45, 75 };

        Selecting.Do(array);
        CollectionAssert.AreEqual(final, array);
    }

    [TestMethod]
    public void DuplicateElementsTest()
    {
        var array = new[] { 7, 5, 56, 3, 7, 18 };
        var final = new[] { 3, 5, 7, 7, 18, 56 };

        Selecting.Do(array);

        CollectionAssert.AreEqual(final, array);
    }
}
