public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int result = 0;

        var freqMap = new Dictionary<char, int>();
        int maxCount = 0;
        for(int right = 0; right<s.Length; right++){
            char ch = s[right];

            if(!freqMap.ContainsKey(ch)) freqMap[ch] = 0;

            freqMap[ch]++;

            maxCount = Math.Max(freqMap[ch], maxCount);

            if((right-left + 1) - maxCount > k){
                freqMap[s[left]]--;
                left++;
            }
            result = Math.Max(result, right-left+1);
        }
        return result;
    }
}
