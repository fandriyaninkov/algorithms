using LeetCode;

namespace Tests.LeetCode;

[TestClass]
public class N509FibonacciTests
{
    [TestMethod]
    public void FibTest()
    {
        var n = 4;

        var res = N509Fibonacci.Do(n);

        Assert.AreEqual(3, res);
    }

    [TestMethod]
    public void Fib1Test()
    {
        var n = 1;

        var res = N509Fibonacci.Do(n);

        Assert.AreEqual(1, res);
    }

    [TestMethod]
    public void Fib0Test()
    {
        var n = 0;

        var res = N509Fibonacci.Do(n);

        Assert.AreEqual(0, res);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FibNegativeTest()
    {
        var n = -1;

        var res = N509Fibonacci.Do(n);
    }
}
