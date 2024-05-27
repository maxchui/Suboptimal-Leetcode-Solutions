// URL: https://leetcode.com/problems/two-sum/
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (map.ContainsKey(diff))
            {
                return new int[] { i, map[diff] };
            }

            map[nums[i]] = i;
        }

        return null;
    }
}