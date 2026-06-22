public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var charMap = new Dictionary<char, int>();

        int longestSeq = 0;
        int start = 0;
        for(int i = 0; i<s.Length; i++){
            if(charMap.ContainsKey(s[i]) && charMap[s[i]] >= start){
                start = charMap[s[i]] + 1;
            }
            charMap[s[i]] = i;

            longestSeq = Math.Max(longestSeq, i - start + 1);
        }

        return longestSeq;
    }
}
