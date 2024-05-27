// URL: https://leetcode.com/problems/maximum-subarray/
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        // Kadane's algorithm
        int max = int.MinValue;
        int maxHere = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            maxHere = maxHere + nums[i];

            if (max < maxHere)
            {
                max = maxHere;
            }

            if (maxHere < 0)
            {
                maxHere = 0;
            }
        }

        return max;
    }
}