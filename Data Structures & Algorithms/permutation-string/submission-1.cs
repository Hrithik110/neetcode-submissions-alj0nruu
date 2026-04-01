public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s2.Length < s1.Length) return false;
        int[] freqS1 = new int[26];
        int[] freqS2 = new int[26];

        for(int i = 0; i<s1.Length; i++){
            int ch = s1[i];

            int index = ch - 'a';

            freqS1[index]++;
        }

        for(int i = 0; i<s2.Length; i++){
            int c = s2[i];
            int idx = c - 'a';
            freqS2[idx]++;

            if(i>=s1.Length){
                freqS2[s2[i-s1.Length] - 'a']--;
            }
            if(Enumerable.SequenceEqual(freqS1, freqS2)){
                return true;
            }
        }

        return false;

    }
}
