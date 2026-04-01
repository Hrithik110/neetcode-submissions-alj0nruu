public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> stringMap1 = new Dictionary<char, int>();
        Dictionary<char, int> stringMap2 = new Dictionary<char, int>();

        for(int i = 0; i<s.Length; i++){
            stringMap1[s[i]] = stringMap1.ContainsKey(s[i])? stringMap1[s[i]] + 1 : 1;
        }

        for(int i = 0; i<t.Length; i++){
            stringMap2[t[i]] = stringMap2.ContainsKey(t[i])? stringMap2[t[i]] + 1 : 1;
        }

        foreach(KeyValuePair<char, int> item in stringMap1 ){
            if(!stringMap2.ContainsKey(item.Key) || stringMap2[item.Key] != item.Value){
                return false;
            }
        }

        return true;
    }
}
