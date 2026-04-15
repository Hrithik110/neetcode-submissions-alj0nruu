public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var charIdxMap = new Dictionary<char, int>();

        int longestSequence = 0;
        int start = 0;

        for(int i = 0; i<s.Length; i++){
            if(charIdxMap.ContainsKey(s[i]) && charIdxMap[s[i]]>= start){
                start = charIdxMap[s[i]] + 1;
            }
            charIdxMap[s[i]] = i;

            longestSequence = Math.Max(longestSequence, i-start+1);
        }

        return longestSequence;
    }
}
