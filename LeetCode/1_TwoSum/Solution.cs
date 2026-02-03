namespace LeetCode._1_TwoSum;

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            var x = target - val;
            if (dictionary.TryGetValue(x, out var ind))
                return [ind, i];

            dictionary[val] = i;
        }

        return Array.Empty<int>();
    }
}
