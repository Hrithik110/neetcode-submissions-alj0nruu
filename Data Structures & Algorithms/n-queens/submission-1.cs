public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        var result = new List<List<string>>();
        var board = new char[n][];
        
        for (int i = 0; i < n; i++) {
            board[i] = new string('.', n).ToCharArray();
        }

        BackTrack(result, board, 0, n);
        return result;
    }

    private void BackTrack(List<List<string>> result, char[][] board, int row, int n) {
        if (row == n) {
            var solution = new List<string>();
            foreach (var r in board) {
                solution.Add(new string(r));
            }
            result.Add(solution);
            return;
        }

        for (int col = 0; col < n; col++) {
            if (IsSafe(board, row, col, n)) {
                board[row][col] = 'Q';
                BackTrack(result, board, row + 1, n);
                board[row][col] = '.'; // backtrack
            }
        }
    }

    private bool IsSafe(char[][] board, int row, int col, int n) {
        // Check column
        for (int i = 0; i < row; i++) {
            if (board[i][col] == 'Q') return false;
        }

        // Check upper-left diagonal
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--) {
            if (board[i][j] == 'Q') return false;
        }

        // Check upper-right diagonal
        for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++) {
            if (board[i][j] == 'Q') return false;
        }

        return true;
    }
}
