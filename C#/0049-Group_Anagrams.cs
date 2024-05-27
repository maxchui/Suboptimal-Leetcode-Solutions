// URL: https://leetcode.com/problems/group-anagrams/
// Time Complexity: O(n * m * log(m))
// Space Complexity: O(n * m)

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] arr = strs[i].ToCharArray();
            Array.Sort(arr);
            String orderedString = new String(arr);

            if (!dict.ContainsKey(orderedString))
            {
                dict.Add(orderedString, new List<String>() { strs[i] });
            }
            else
            {
                dict[orderedString].Add(strs[i]);
            }
        }

        return dict.Values.ToList();
    }
}