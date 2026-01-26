namespace LeetCode._509_Fibonacci;

/// <summary>Алгоритм с сохранением результатов. Время O(n)</summary>
public class Dp
{
    public static int FibDp(int n, IDictionary<int, int> values)
    {
        if (values.ContainsKey(n))
            return values[n];

        if (n <= 1)
            return n;

        values[n] = FibDp(n - 1, values) + FibDp(n - 2, values);
        return values[n];
    }
}
