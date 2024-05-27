// URL: https://leetcode.com/problems/container-with-most-water/
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public int MaxArea(int[] height)
    {
        // Two pointers approach
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int minHeight = Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, width * minHeight);

            // Move the pointer pointing to the shorter line
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}