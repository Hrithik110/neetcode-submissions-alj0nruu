public class Solution {
    public bool IsAnagram(string s, string t) {

        Dictionary<char, int> charMap = new Dictionary<char, int>();

        foreach(char ch in s){
            charMap[ch] = charMap.GetValueOrDefault(ch, 0) + 1;
        }

        foreach(char c in t){
            if(!charMap.ContainsKey(c)) return false;

            charMap[c]--;

            if(charMap[c] == 0){
                charMap.Remove(c);
            }
        }

        return charMap.Count == 0;
    }
}
