public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i = 0; i<9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i = 0; i<9; i++){
            for(int j = 0; j<9; j++){
                char num = board[i][j];
                
                if(num=='.'){
                    continue;
                }


                int boxIdx = (i/3) *3 + (j/3);

                if(rows[i].Contains(num) || cols[j].Contains(num) || boxes[boxIdx].Contains(num)){
                    return false;
                }

                rows[i].Add(num);
                cols[j].Add(num);
                boxes[boxIdx].Add(num);
            }
        }
        return true;
    }
}
