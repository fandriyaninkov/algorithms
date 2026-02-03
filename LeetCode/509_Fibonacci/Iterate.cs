namespace LeetCode._509_Fibonacci;

/// <summary>Версия на цикле. Скорость O(n)</summary>
public class Iterate
{
    public static int Fib(int n)
    {
        if (n <= 1)
            return n;

        var prev = 0;
        var cur = 1;
        for (var i = 2; i < n; i++)
        {
            var next = cur + prev;
            prev = cur;
            cur = next;
        }

        return prev + cur;
    }
}
