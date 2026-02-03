namespace LeetCode._912_SortArray;

public class Partitional
{
    public static int[] SortArray(int[] nums)
    {
        QuickSort3Way(nums, 0, nums.Length - 1);
        return nums;
    }

    public static void QuickSort3Way(int[] nums, int left, int right)
    {
        while (right > left)
        {
            var lt = left;
            var i = left;
            var rt = right;
            var pivot = Middle(nums[left], nums[(left + right) / 2], nums[right]);
            while (i <= rt)
            {
                if (nums[i] < pivot)
                {
                    Swap(nums, lt, i);
                    lt++;
                    i++;
                }
                else if (nums[i] > pivot)
                {
                    Swap(nums, i, rt);
                    rt--;
                }
                else
                {
                    i++;
                }    
            }

            if (lt - left < right - rt)
            {
                QuickSort3Way(nums, left, lt - 1);
                left = rt + 1;
            }
            else
            {
                QuickSort3Way(nums, rt + 1, right);
                right = lt - 1;
            }
        }
    }

    private static int Middle(int first, int second, int third)
    {
        if (first > second && first > third)
            return second > third ? second : third;
        if (second > first && second > third)
            return first > third ? first : third;

        return third;
    }

    private static void Swap(int[] nums, int l, int r)
    {
        if (l == r)
            return;

        var t = nums[l];
        nums[l] = nums[r];
        nums[r] = t;
    }
}
