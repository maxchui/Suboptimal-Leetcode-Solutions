// URL: https://leetcode.com/problems/richest-customer-wealth/
// Time Complexity: O(n*m)
// Space Complexity: O(1)

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int largest = 0;
        foreach (int[] account in accounts)
        {
            int sum = 0;
            for (int i = 0; i < account.Length; i++)
            {
                sum += account[i];
            }
            if (sum > largest)
            {
                largest = sum;
            }
        }
        return largest;
    }

}