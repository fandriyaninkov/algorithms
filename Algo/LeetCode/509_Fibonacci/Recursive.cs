namespace LeetCode._509_Fibonacci;

/// <summary>Рекурсивная версия. Сложность O(2^n)</summary>
public static class Recursive
{
    public static int Do(int n)
    {
        if (n < 0)
            throw new ArgumentException("n не может быть отрицательным");

        if (n == 0)
            return 0;
        if (n == 1)
           return 1;

        return Do(n - 1) + Do(n - 2);
    }
}
