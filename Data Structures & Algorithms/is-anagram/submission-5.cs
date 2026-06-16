public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

       var dict = new Dictionary<char, int>();

       foreach(char ch in s){
        dict[ch] = dict.GetValueOrDefault(ch, 0) + 1;
       }

       foreach(char ch in t){
        if(!dict.ContainsKey(ch)) return false;

        dict[ch]--;

        if(dict[ch] == 0){
            dict.Remove(ch);
        }
       }
        return dict.Count == 0;
    }
}
