namespace LeetCode._217_DuplicateElements;

public class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        var dictionary = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            if (dictionary.ContainsKey(val))
                return true;

            dictionary.Add(val, i);
        }

        return false;
    }
}
