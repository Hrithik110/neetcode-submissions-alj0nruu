public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int left = 0;
        int[] freq = new int[26];

        int maxFreq = 0;
        int maxLen = 0;

        for(int r = 0; r<s.Length;r++){
            int index = s[r] - 'A';

            freq[index]++;
            maxFreq = Math.Max(maxFreq, freq[index]);

            while((r-left+1)-maxFreq > k){
                freq[s[left] - 'A']--;
                left++;
            }

            maxLen = Math.Max(maxLen, r-left+1);
        }

        return maxLen;
    }
}
