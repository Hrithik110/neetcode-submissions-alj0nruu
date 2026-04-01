public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        

        for(int i = 0; i<s.Length; i++){
            charCount[s[i]] = charCount.ContainsKey(s[i])? charCount[s[i]] + 1 : 1;
        }

        foreach(char ch in t){
            if(!charCount.ContainsKey(ch)){
                return false;
            }
            charCount[ch]--;
            if(charCount[ch] < 0) return false;
        }

        return true;
    }
}
