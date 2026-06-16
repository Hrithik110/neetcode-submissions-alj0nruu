public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] charFreq_s = new int[26];
        int[] charFreq_t = new int[26];

        foreach(char ch in s){
            int idx = ch - 'a';

            charFreq_s[idx]++;
        }

        foreach(char ch in t){
            int idx = ch - 'a';

            charFreq_t[idx]++;
        }

        string key_s = string.Join(',',charFreq_s);
        string key_t = string.Join(',',charFreq_t);

        return key_s == key_t;

    }
}
