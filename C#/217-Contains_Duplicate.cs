// URL: https://leetcode.com/problems/contains-duplicate/
// Time Complexity: O(n)
// Space Complexity: O(n)

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return nums.Length != new HashSet<int>(nums).Count;
    }
}