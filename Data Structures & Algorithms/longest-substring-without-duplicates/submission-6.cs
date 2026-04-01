public class Solution {
    public int LengthOfLongestSubstring(string str) {
        var charMap = new Dictionary<char, int>();
        int start = 0;
        int longestSubstring = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (charMap.ContainsKey(str[i]) && charMap[str[i]] >= start)
            {
                start = charMap[str[i]] + 1;
            }
            charMap[str[i]] = i;

            longestSubstring = Math.Max(longestSubstring, i - start + 1);
        }

        return longestSubstring;
}
    }

