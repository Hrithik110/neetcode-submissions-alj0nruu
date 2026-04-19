public class WordDictionary {
    public TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        var curr = root;

        foreach(char ch in word){
            if(curr.children[ch-'a'] == null){
                curr.children[ch-'a'] = new TrieNode();
            }

            curr = curr.children[ch-'a'];
        }

        curr.isLeaf = true;
    }
    
    public bool Search(string word) {
        return BackTrack(word, 0, root);
    }

    public bool BackTrack(string word, int idx, TrieNode root){
        var curr = root;

        for(int i = idx; i<word.Length; i++){
            if(word[i] == '.'){
                for(int j = 0; j<26; j++){
                    if(curr.children[j]!=null && BackTrack(word, i+1, curr.children[j])){
                        return true;
                    }
                }
                return false;
            }
            else{
                if(curr.children[word[i]-'a'] == null) return false;

                curr = curr.children[word[i]-'a'];
            }
        }

        return curr.isLeaf;
    }
}

public class TrieNode{
    public TrieNode[] children = new TrieNode[26];
    public bool isLeaf = false;
}