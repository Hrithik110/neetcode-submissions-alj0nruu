public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;

        for(int i = 0; i<m; i++){
            for(int j = 0; j<n; j++){
                if(BackTrack(board, word, i, j, 0)){
                    return true;
                }
            }
        }
        return false;
    }
    
    public bool BackTrack(char[][] board, string word, int i, int j, int index){
        if(index == word.Length) return true;


        if(i<0 || j<0 || i>=board.Length || j>=board[0].Length || board[i][j] != word[index]) return false;

        char temp = board[i][j];

        board[i][j] = '#';

        bool found = BackTrack(board, word, i+1, j, index+1)
        ||BackTrack(board, word, i-1, j, index+1)
        ||BackTrack(board, word, i, j+1, index+1)
        ||BackTrack(board, word, i, j-1, index+1);

        board[i][j] = temp;

        return found;
    }
}
