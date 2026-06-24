public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        var charDict = new Dictionary<char, int>();

        int result = 0;
        int maxFreq = 0;
        int start = 0;
        for(int i = 0; i<s.Length; i++){
            char ch = s[i];
            charDict[ch] = charDict.GetValueOrDefault(ch, 0) + 1;
            maxFreq = Math.Max(maxFreq, charDict[ch]);

            if((i - start + 1) - maxFreq > k){
                char cL = s[start];

                charDict[cL]--;
                start++;
            }
            result = Math.Max(result, i-start+1);
        }
        return result;
    }
}
