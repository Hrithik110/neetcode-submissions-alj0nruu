public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

         for(int i = 0; i<9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i = 0; i<board.Length; i++){

            for(int j = 0; j<board[0].Length; j++){

                char ch = board[i][j];

                if(ch == '.') continue;

                int boxIdx = (i/3)*3 + j/3;

                if(rows[i].Contains(ch) || cols[j].Contains(ch) || boxes[boxIdx].Contains(ch)){
                    return false;
                }
                rows[i].Add(ch);
                cols[j].Add(ch);
                boxes[boxIdx].Add(ch);
            }
        }

        return true;

    }
}
