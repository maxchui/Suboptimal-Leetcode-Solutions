// URL: https://leetcode.com/problems/palindrome-number/
// Time complexity: O(n)
// Space complexity: O(1)

public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers are not palindromes
        if (x < 0) return false;

        string str = x.ToString();

        // Use the two-pointer technique to check if the string is a palindrome
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}