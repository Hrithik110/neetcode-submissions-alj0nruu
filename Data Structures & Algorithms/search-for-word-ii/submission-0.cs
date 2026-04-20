public class Solution {
    public List<string> result;
    public List<string> FindWords(char[][] board, string[] words) {
        var root = new TrieNode();

        foreach(string word in words){
            AddWord(root, word);
        }

        result = new List<string>();

        for(int i = 0; i< board.Length; i++){
            for(int j = 0; j<board[0].Length; j++){
                BackTrack(board, i, j, root);
            }
        }
        return result;
    }

    public void BackTrack(char[][]board, int i, int j, TrieNode node){
        
        if(i<0 || j<0 || i>=board.Length || j>=board[0].Length
         ){
            return;
         }
        char ch = board[i][j];
        if (ch == '#' || node.children[ch - 'a'] == null) return;
         node = node.children[ch-'a'];

         if(node.word!=null){
            result.Add(node.word);
            node.word = null;
         }

         board[i][j] = '#';

         BackTrack(board, i-1, j, node);
         BackTrack(board, i, j-1, node);
         BackTrack(board, i+1, j, node);
         BackTrack(board, i, j+1, node);

        board[i][j] = ch;


    }


    public void AddWord(TrieNode root, string word){

        var curr = root;

        foreach(char ch in word){
            if(curr.children[ch-'a'] == null){
                curr.children[ch-'a'] = new TrieNode();
            }

            curr = curr.children[ch-'a'];
        }

        curr.word = word;
    }
}

public class TrieNode{
    public TrieNode[] children = new TrieNode[26];
    public string word = null;
}