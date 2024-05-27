// URL: https://leetcode.com/problems/valid-anagram/
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int c in count)
        {
            if (c != 0)
            {
                return false;
            }
        }

        return true;
    }
}
