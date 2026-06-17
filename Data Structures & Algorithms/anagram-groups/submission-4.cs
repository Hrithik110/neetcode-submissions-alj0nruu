public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var anagramList = new Dictionary<string, List<string>>();

        for(int i = 0; i<strs.Length; i++){
            var charMap = new int[26];

            foreach(char ch in strs[i]){
                int idx = ch - 'a';
                charMap[idx]++;
            }

            var key = string.Join(',', charMap);

            if(!anagramList.ContainsKey(key)){
                anagramList[key] = new List<string>();
            }
            anagramList[key].Add(strs[i]);
        }

        return anagramList.Values.ToList();
    }
}
