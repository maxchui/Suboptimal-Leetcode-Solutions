// URL: https://leetcode.com/problems/largest-odd-number-in-string/
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public string LargestOddNumber(string num)
    {
        for (int i = num.Length; i > 0; i--)
        {
            if (Char.GetNumericValue(num[i - 1]) % 2 == 1)
            {
                return num.Substring(0, i);
            }
        }

        return "";
    }
}