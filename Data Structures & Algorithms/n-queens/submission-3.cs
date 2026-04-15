public class Solution {
    public List<List<string>> result;
    public List<List<string>> SolveNQueens(int n) {
        result = new List<List<string>>();
        char[][] board = new char[n][];

        for(int i = 0; i<n; i++){
            board[i] = new string('.', n).ToCharArray();
        }

        BackTrack(board, 0, n);

        return result;

    }

    public void BackTrack(char[][] board, int row, int n){
        if(row == n){
            //save in result
            var sol = new List<string>();

            foreach(char[] c in board){
                sol.Add(new string(c));
            }
            result.Add(sol);
        }

        for(int col = 0; col<n; col++){
            if(IsSafeToPlace(board, row, col, n)){
                board[row][col] = 'Q';
                BackTrack(board, row+1, n);

                board[row][col] = '.';
            }
        }
    }

    public bool IsSafeToPlace(char[][] board, int row, int col, int n){

        // check in col above
        for(int i = 0; i<row; i++){
            if(board[i][col] == 'Q') return false;
        }

        // check in upper left diagonal

        for(int i = row-1, j = col-1; i>=0 && j>=0; i--, j--){
            if(board[i][j]=='Q') return false;
        }

        //check in upper right diagonal

        for(int i = row-1, j = col+1; i>=0 && j<n; i--, j++){
            if(board[i][j]=='Q') return false;
        }

        return true;
    }
    
}
