public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        

        Dictionary<string, List<string>> anagramsMap = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            // Sort characters in the word
            string sorted = String.Concat(word.OrderBy(c => c));

            // Add to dictionary
            if (!anagramsMap.ContainsKey(sorted)) {
                anagramsMap[sorted] = new List<string>();
            }
            anagramsMap[sorted].Add(word);
        }

        // Convert dictionary values to result
        return anagramsMap.Values.ToList();

    }
}
