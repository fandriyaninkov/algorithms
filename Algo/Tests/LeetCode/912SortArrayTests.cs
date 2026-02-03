using LeetCode._912_SortArray;

namespace Tests.LeetCode;

[TestClass]
public class N912SortArrayTests
{
    [TestMethod]
    public void QuickTest()
    {
        var array = new[] { 156, 141, 35, 94, 88, 61, 111 };
        var final = new[] { 35, 61, 88, 94, 111, 141, 156 };

        var res = Quick.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickEmptyTest()
    {
        var array = Array.Empty<int>();
        var res = Quick.SortArray(array);

        Assert.AreEqual(0, res.Length);
    }

    [TestMethod]
    public void SingleElementTest()
    {
        var array = new[] { 42 };
        var final = new[] { 42 };

        var res = Quick.SortArray(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void SortTest()
    {
        var array = new[] { 3, 6, 9, 45, 75 };
        var final = new[] { 3, 6, 9, 45, 75 };

        var res = Quick.SortArray(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void DuplicateElementsTest()
    {
        var array = new[] { 7, 5, 56, 3, 7, 18 };
        var final = new[] { 3, 5, 7, 7, 18, 56 };

        var res = Quick.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void NegativeElementsTest()
    {
        var array = new[] { 0, -1, 5, -10 };
        var final = new[] { -10, -1, 0, 5 };

        var res = Quick.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void SameElementsTest()
    {
        var array = new[] { 7, 7, 7, 7 };
        var final = new[] { 7, 7, 7, 7 };

        var res = Quick.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    #region Index
    [TestMethod]
    public void QuickIndexTest()
    {
        var array = new[] { 156, 141, 35, 94, 88, 61, 111 };
        var final = new[] { 35, 61, 88, 94, 111, 141, 156 };

        var res = QuickIndex.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexEmptyTest()
    {
        var array = Array.Empty<int>();
        var res = QuickIndex.SortArray(array);

        Assert.AreEqual(0, res.Length);
    }

    [TestMethod]
    public void QuickIndexSingleElementTest()
    {
        var array = new[] { 42 };
        var final = new[] { 42 };

        var res = QuickIndex.SortArray(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexSortTest()
    {
        var array = new[] { 3, 6, 9, 45, 75 };
        var final = new[] { 3, 6, 9, 45, 75 };

        var res = QuickIndex.SortArray(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexDuplicateElementsTest()
    {
        var array = new[] { 7, 5, 56, 3, 7, 18 };
        var final = new[] { 3, 5, 7, 7, 18, 56 };

        var res = QuickIndex.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexNegativeElementsTest()
    {
        var array = new[] { 0, -1, 5, -10 };
        var final = new[] { -10, -1, 0, 5 };

        var res = QuickIndex.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexSameElementsTest()
    {
        var array = new[] { 7, 7, 7, 7 };
        var final = new[] { 7, 7, 7, 7 };

        var res = QuickIndex.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexLeetcodeCaseTest()
    {
        var array = new[] { 5, 1, 1, 2, 0, 0 };
        var final = new[] { 0, 0, 1, 1, 2, 5 };

        var res = QuickIndex.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexLeetcodeCase2Test()
    {
        var array = new[] { -4, 0, 7, 4, 9, -5, -1, 0, -7, -1 };
        var final = new[] { -7, -5, -4, -1, -1, 0, 0, 4, 7, 9 };

        var res = QuickIndex.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void QuickIndexLeetcodeCase3Test()
    {
        var array = new[] { -74, 48, -20, 2, 10, -84, -5, -9, 11, -24, -91, 2, -71, 64, 63, 80, 28, -30, -58, -11, -44, -87, -22, 54, -74, -10, -55, -28, -46, 29, 10, 50, -72, 34, 26, 25, 8, 51, 13, 30, 35, -8, 50, 65, -6, 16, -2, 21, -78, 35, -13, 14, 23, -3, 26, -90, 86, 25, -56, 91, -13, 92, -25, 37, 57, -20, -69, 98, 95, 45, 47, 29, 86, -28, 73, -44, -46, 65, -84, -96, -24, -12, 72, -68, 93, 57, 92, 52, -45, -2, 85, -63, 56, 55, 12, -85, 77, -39 };
        var final = new[] { -96, -91, -90, -87, -85, -84, -84, -78, -74, -74, -72, -71, -69, -68, -63, -58, -56, -55, -46, -46, -45, -44, -44, -39, -30, -28, -28, -25, -24, -24, -22, -20, -20, -13, -13, -12, -11, -10, -9, -8, -6, -5, -3, -2, -2, 2, 2, 8, 10, 10, 11, 12, 13, 14, 16, 21, 23, 25, 25, 26, 26, 28, 29, 29, 30, 34, 35, 35, 37, 45, 47, 48, 50, 50, 51, 52, 54, 55, 56, 57, 57, 63, 64, 65, 65, 72, 73, 77, 80, 85, 86, 86, 91, 92, 92, 93, 95, 98 };

        var res = QuickIndex.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }
    #endregion

    #region Partitional
    [TestMethod]
    public void PartitionalTest()
    {
        var array = new[] { 156, 141, 35, 94, 88, 61, 111 };
        var final = new[] { 35, 61, 88, 94, 111, 141, 156 };

        var res = Partitional.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalEmptyTest()
    {
        var array = Array.Empty<int>();
        var res = Partitional.SortArray(array);

        Assert.AreEqual(0, res.Length);
    }

    [TestMethod]
    public void PartitionalSingleElementTest()
    {
        var array = new[] { 42 };
        var final = new[] { 42 };

        var res = Partitional.SortArray(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalSortTest()
    {
        var array = new[] { 3, 6, 9, 45, 75 };
        var final = new[] { 3, 6, 9, 45, 75 };

        var res = Partitional.SortArray(array);
        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalDuplicateElementsTest()
    {
        var array = new[] { 7, 5, 56, 3, 7, 18 };
        var final = new[] { 3, 5, 7, 7, 18, 56 };

        var res = Partitional.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalNegativeElementsTest()
    {
        var array = new[] { 0, -1, 5, -10 };
        var final = new[] { -10, -1, 0, 5 };

        var res = Partitional.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalSameElementsTest()
    {
        var array = new[] { 7, 7, 7, 7 };
        var final = new[] { 7, 7, 7, 7 };

        var res = Partitional.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalLeetcodeCaseTest()
    {
        var array = new[] { 5, 1, 1, 2, 0, 0 };
        var final = new[] { 0, 0, 1, 1, 2, 5 };

        var res = Partitional.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalLeetcodeCase2Test()
    {
        var array = new[] { -4, 0, 7, 4, 9, -5, -1, 0, -7, -1 };
        var final = new[] { -7, -5, -4, -1, -1, 0, 0, 4, 7, 9 };

        var res = Partitional.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }

    [TestMethod]
    public void PartitionalLeetcodeCase3Test()
    {
        var array = new[] { -74, 48, -20, 2, 10, -84, -5, -9, 11, -24, -91, 2, -71, 64, 63, 80, 28, -30, -58, -11, -44, -87, -22, 54, -74, -10, -55, -28, -46, 29, 10, 50, -72, 34, 26, 25, 8, 51, 13, 30, 35, -8, 50, 65, -6, 16, -2, 21, -78, 35, -13, 14, 23, -3, 26, -90, 86, 25, -56, 91, -13, 92, -25, 37, 57, -20, -69, 98, 95, 45, 47, 29, 86, -28, 73, -44, -46, 65, -84, -96, -24, -12, 72, -68, 93, 57, 92, 52, -45, -2, 85, -63, 56, 55, 12, -85, 77, -39 };
        var final = new[] { -96, -91, -90, -87, -85, -84, -84, -78, -74, -74, -72, -71, -69, -68, -63, -58, -56, -55, -46, -46, -45, -44, -44, -39, -30, -28, -28, -25, -24, -24, -22, -20, -20, -13, -13, -12, -11, -10, -9, -8, -6, -5, -3, -2, -2, 2, 2, 8, 10, 10, 11, 12, 13, 14, 16, 21, 23, 25, 25, 26, 26, 28, 29, 29, 30, 34, 35, 35, 37, 45, 47, 48, 50, 50, 51, 52, 54, 55, 56, 57, 57, 63, 64, 65, 65, 72, 73, 77, 80, 85, 86, 86, 91, 92, 92, 93, 95, 98 };

        var res = Partitional.SortArray(array);

        CollectionAssert.AreEqual(final, res);
    }
    #endregion

}
