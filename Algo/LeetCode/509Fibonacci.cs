namespace LeetCode;

public static class N509Fibonacci
{
    public static int Do(int n)
    {
        if (n < 0)
            throw new ArgumentException("Не может быть отрицательное число");

        if (n == 0)
            return 0;
        if (n == 1)
           return 1;

        return Do(n - 1) + Do(n - 2);
    }
}
