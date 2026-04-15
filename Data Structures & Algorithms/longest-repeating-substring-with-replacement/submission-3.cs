public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] charFreq = new int[26];

        int maxCount = 0;

        int maxLen = 0;
        int start = 0;
        for(int i = 0; i<s.Length; i++){
            char ch = s[i];
            charFreq[ch-'A']++;

            maxCount = Math.Max(maxCount, charFreq[ch-'A']);

            if((i-start+1) - maxCount>k){
               

                char cL = s[start];

                charFreq[cL-'A']--;

                start++;

            }
             maxLen =Math.Max(maxLen, i-start+1);
        }

        return maxLen;
    }
}
