using LeetCode._509_Fibonacci;

namespace Tests.LeetCode;

[TestClass]
public class N509FibonacciTests
{
    [TestMethod]
    [DataRow(4, 3)]
    [DataRow(1, 1)]
    [DataRow(0, 0)]
    public void FibTest(int n, int expected)
    {
        var res = Recursive.Do(n);
        Assert.AreEqual(expected, res);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FibNegativeTest()
    {
        var n = -1;
        Recursive.Do(n);
    }

    [TestMethod]
    [DataRow(4, 3)]
    [DataRow(1, 1)]
    [DataRow(0, 0)]
    public void FibDpTest(int n, int expected)
    {
        var res = Dp.FibDp(n, new Dictionary<int, int>());
        Assert.AreEqual(expected, res);
    }

    [TestMethod]
    [DataRow(4, 3)]
    [DataRow(1, 1)]
    [DataRow(0, 0)]
    public void FibIterateTest(int n, int expected)
    {
        var res = Iterate.Fib(n);
        Assert.AreEqual(expected, res);
    }
}
