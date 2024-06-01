// URL: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
// Time Complexity: O(4^n)
// Space Complexity: O(4^n)

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return [];

        Dictionary<string, string> map = new Dictionary<string, string>(){
            {"2", "abc"},
            {"3", "def"},
            {"4", "ghi"},
            {"5", "jkl"},
            {"6", "mno"},
            {"7", "qprs"},
            {"8", "tuv"},
            {"9", "wxyz"}
        };

        IList<string> combinations = new List<string>();

        void Backtracking(int index, string current)
        {
            if (current.Length == digits.Length)
            {
                combinations.Add(current);
                return;
            }

            string chars = map[digits[index].ToString()];

            for (int i = 0; i < chars.Length; i++)
            {
                Backtracking(index + 1, current + chars[i]);
            }
        }

        Backtracking(0, "");

        return combinations;
    }
}