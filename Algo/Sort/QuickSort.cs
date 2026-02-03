namespace Algo.Sort;

/// <summary>
/// Быстрая сортировка.
/// Время худший случай O(n^2). Средний случай O(n*log(n))
/// </summary>
public static class QuickSort
{
    public static int[] Do(int[] nums)
    {
        if (nums == null)
            return Array.Empty<int>();

        if (nums.Length < 2)
            return nums;

        var pos = new Random().Next(0, nums.Length - 1);
        var el = nums[pos];
        var less = new List<int>();
        var greather = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i == pos)
                continue;

            var val = nums[i];
            if (el > val)
                less.Add(val);
            else
                greather.Add(val);
        }

        return Do(less.ToArray())
            .Concat([el])
            .Concat(Do(greather.ToArray()))
            .ToArray();
    }
}
