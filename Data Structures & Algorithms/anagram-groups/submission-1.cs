public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        

        Dictionary<string, List<string>> anagramsMap = new Dictionary<string, List<string>>();

        
        foreach(string str in strs){
            int[] counts = new int[26];

            foreach(char c in str){
                counts[c-'a']++;
            }

            string key = string.Join(',', counts);

            if(!anagramsMap.ContainsKey(key)){
                anagramsMap[key] = new List<string>();
            }
            anagramsMap[key].Add(str);
        }

        return anagramsMap.Values.ToList();

    }
}
