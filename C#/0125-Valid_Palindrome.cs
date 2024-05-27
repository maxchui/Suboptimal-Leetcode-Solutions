// URL: https://leetcode.com/problems/valid-palindrome/
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public bool IsPalindrome(string s)
    {
        // Two pointers approach
        for (int i = 0, j = s.Length - 1; j > i;)
        {
            if (!Char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }

            if (!Char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }

            if (Char.ToLower(s[i++]) != Char.ToLower(s[j--]))
            {
                return false;
            }
        }

        return true;
    }
}