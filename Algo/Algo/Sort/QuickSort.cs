namespace Algo.Sort;

/// <summary>
/// Быстрая сортировка.
/// Время худший случай O(n^2). Средний случай O(n*log(n))
/// </summary>
public static class QuickSort
{
    public static int[] Do(int[] nums)
    {
        if (nums.Length < 2)
            return nums;

        var el = nums[0];
        var less = nums.Skip(1).Where(x => x <= el).ToArray();
        var greather = nums.Skip(1).Where(x => x > el).ToArray();
        return Do(less)
            .Concat([el])
            .Concat(Do(greather))
            .ToArray();
    }
}
