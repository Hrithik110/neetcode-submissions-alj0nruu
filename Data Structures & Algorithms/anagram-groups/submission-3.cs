public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagramMap = new Dictionary<string, List<string>>();


        for(int i = 0; i<strs.Length; i++){
            string s = strs[i];
            int[] charMap = new int[26];
            foreach(char ch in s){
                charMap[ch-'a']++; 
            }

            string key = string.Join(',', charMap);

            if(!anagramMap.ContainsKey(key)){
                anagramMap[key] = new List<string>();
            }
            anagramMap[key].Add(s);

        }

        return anagramMap.Values.ToList();
    }
}
