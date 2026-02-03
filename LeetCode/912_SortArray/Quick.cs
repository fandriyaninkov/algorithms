namespace LeetCode._912_SortArray;

public class Quick
{
    public static int[] SortArray(int[] nums)
    {
        if (nums == null)
            return Array.Empty<int>();

        if (nums.Length < 2)
            return nums;

        var pos = new Random().Next(0, nums.Length - 1);
        var el = nums[pos];
        var less = new List<int>();
        var same = new List<int> { el };
        var greather = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i == pos)
                continue;

            var val = nums[i];
            if (el == val)
                same.Add(val);
            else if (el > val)
                less.Add(val);
            else
                greather.Add(val);
        }

        return SortArray(less.ToArray())
            .Concat(same.ToArray())
            .Concat(SortArray(greather.ToArray()))
            .ToArray();
    }
}
