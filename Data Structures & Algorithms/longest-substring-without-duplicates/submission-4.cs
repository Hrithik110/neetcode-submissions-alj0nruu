public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var map = new Dictionary<char,int>();
        int start = 0;
        int maxCount = 0;
        for(int i = 0; i<s.Length; i++){
            if(map.ContainsKey(s[i]) && map[s[i]]>=start){
                start = map[s[i]] + 1;
            }
            map[s[i]] = i;
            maxCount = Math.Max(maxCount, i-start+1);

        }
        return maxCount;

    }
}
