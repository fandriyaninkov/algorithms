namespace LeetCode._912_SortArray;

/// <summary>Оказался полным говном. Худший варианнт по литкоду</summary>
public class QuickIndex
{
    public static int[] SortArray(int[] nums)
    {
        SortPartitional(nums, 0, nums.Length - 1);
        return nums;
    }

    public static void SortPartitional(int[] nums, int start, int end)
    {
         if (start >= end)
            return;

        var pivIndex = start; 
        var same = 0;
        for (int i = start + 1; i <= end; i++)
        {
            var cur = nums[i];
            var piv = nums[pivIndex];
            if (piv < cur)
                continue;
            if (piv >= cur)
            {
                if ((i - pivIndex) == 1 && piv != cur)
                {
                    nums[i] = piv;
                    nums[pivIndex] = cur;
                }
                else
                {
                    nums[i] = nums[pivIndex + 1 + same];
                    nums[pivIndex + 1 + same] = piv;
                    nums[pivIndex] = cur;
                }
                if (piv == cur)
                    same++;
                else
                    pivIndex++;
            }           
        }
        SortPartitional(nums, start, pivIndex - 1);
        SortPartitional(nums, pivIndex + 1 + same, end);
    }
}
