public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0, r = 0;

        var freqMap = new Dictionary<char, int>();
        int maxCount = 0;

        int result = 0;
        while(r<s.Length){
            char ch = s[r];

            if(!freqMap.ContainsKey(ch)) freqMap[ch] = 0;

            freqMap[ch]++;

            maxCount = Math.Max(maxCount, freqMap[ch]);

            if((r-l + 1) - maxCount > k){
                freqMap[s[l]]--;
                l++;
            }
            result = Math.Max(result, r-l+1);

            r++;
        }
        return result;
    }
}
