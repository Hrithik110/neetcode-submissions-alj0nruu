public class WordDictionary {
    public TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
         TrieNode curr = root;

        foreach(char ch in word){
            if(curr.children[ch-'a'] == null){
                curr.children[ch-'a'] = new TrieNode();
            }

            curr = curr.children[ch-'a'];
        }

        curr.isLeaf = true;

        curr = root;

    }
    
    public bool Search(string word) {
        return BackTrack(0, root, word);
    }

    public bool BackTrack(int idx, TrieNode root, string word){
        TrieNode curr = root;

        for(int i = idx; i<word.Length; i++){
            char ch = word[i];

            if(ch == '.'){
                for (int j = 0; j < 26; j++) {
                    if (curr.children[j] != null &&
                        BackTrack(i + 1, curr.children[j], word)) {
                        return true;
                    }
                }
                return false;
            }
            else{
                int childIdx = ch - 'a';
                if (curr.children[childIdx] == null) return false;
                curr = curr.children[childIdx];
            }
        }

        return curr.isLeaf;
    }
}

public class TrieNode{
    public TrieNode[] children = new TrieNode[26];
    public bool isLeaf = false;
}