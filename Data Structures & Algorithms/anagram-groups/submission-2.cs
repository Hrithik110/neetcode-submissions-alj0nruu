public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var result = new List<List<string>>();

        var anagramMap = new Dictionary<string, List<string>>();

        for(int i = 0; i<strs.Length; i++){
            int[] counts = new int[26];

            foreach(char c in strs[i]){
                counts[c-'a']++;
            }

            string key = string.Join(',',counts);

            if(!anagramMap.ContainsKey(key)){
                anagramMap[key] = new List<string>();
            }

            anagramMap[key].Add(strs[i]);
        }

        return anagramMap.Values.ToList();
    }
}
