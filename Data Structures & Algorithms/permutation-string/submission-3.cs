public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] charFreq1 = new int[26];
        int[] charFreq2 = new int[26];

        foreach(char c in s1){
            charFreq1[c-'a']++;
        }

       for(int i = 0; i<s2.Length; i++){
            char ch = s2[i];

            charFreq2[ch-'a']++;

            if(i>=s1.Length){
                charFreq2[s2[i-s1.Length] - 'a']--;
            }

            if(charFreq2.SequenceEqual(charFreq1)){
                return true;
            }
       }



        return false;
    }
}
