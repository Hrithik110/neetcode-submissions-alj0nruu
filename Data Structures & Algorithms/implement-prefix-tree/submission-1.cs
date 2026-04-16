public class PrefixTree {
    public TrieNode root;
    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;

        foreach(char ch in word){
            if(curr.children[ch-'a'] == null){
                curr.children[ch-'a'] = new TrieNode();
            }

            curr = curr.children[ch-'a'];
        }

        curr.isLeaf = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = root;

        foreach(char ch in word){
            if(curr.children[ch-'a'] == null) return false;

            curr = curr.children[ch-'a'];
        }
        return curr.isLeaf;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode curr = root;

        foreach(char ch in prefix){
            if(curr.children[ch-'a'] == null) return false;

            curr = curr.children[ch-'a'];
        }

        return true;
    }
}


public class TrieNode{
    public TrieNode[] children = new TrieNode[26];
    public bool isLeaf = false;
    public TrieNode()
    {
        isLeaf = false;
        for (int i = 0; i < 26; i++) {
            children[i] = null;
        }
    }
}