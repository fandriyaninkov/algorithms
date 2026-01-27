using Algo.Sort;

namespace Tests.AlgoTests.Sort;

[TestClass]
public class QuickTests
{
    [TestMethod]
    public void QuickTest()
    {
        var array = new[] { 156, 141, 35, 94, 88, 61, 111 };
        var final = new[] { 35, 61, 88, 94, 111, 141, 156 };

        var res = QuickSort.Do(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickEmptyTest()
    {
        var array = Array.Empty<int>();
        var res = QuickSort.Do(array);

        Assert.AreEqual(0, res.Length);
    }

    [TestMethod]
    public void SingleElementTest()
    {
        var array = new[] { 42 };
        var final = new[] { 42 };

        var res = QuickSort.Do(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void SortTest()
    {
        var array = new[] { 3, 6, 9, 45, 75 };
        var final = new[] { 3, 6, 9, 45, 75 };

        var res = QuickSort.Do(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void DuplicateElementsTest()
    {
        var array = new[] { 7, 5, 56, 3, 7, 18 };
        var final = new[] { 3, 5, 7, 7, 18, 56 };

        var res = QuickSort.Do(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void NegativeElementsTest()
    {
        var array = new[] { 0, -1, 5, -10 };
        var final = new[] { -10, -1, 0, 5 };

        var res = QuickSort.Do(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void SameElementsTest()
    {
        var array = new[] { 7, 7, 7, 7 };
        var final = new[] { 7, 7, 7, 7 };

        var res = QuickSort.Do(array);

        CollectionAssert.AreEqual(final, res);
    }
}
