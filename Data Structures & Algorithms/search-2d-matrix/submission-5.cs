public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cols = matrix[0].Length;
        int rows = matrix.Length;

        int rowTop = 0, rowBottom = rows-1;

        while(rowTop <= rowBottom){
            int midRow = rowTop + (rowBottom - rowTop)/2;

            if(target > matrix[midRow][cols-1]){
                rowTop = midRow + 1;
            }
            else if(target < matrix[midRow][0]){
                rowBottom = midRow - 1;
            }
            else{
                break;
            }
        }

        if(rowTop > rowBottom){
            return false;
        }

        int row = rowTop + (rowBottom - rowTop)/2;

        int l = 0, r = cols-1;

        while(l<=r){
            int midCol = l + (r-l)/2;

            if(target > matrix[row][midCol]){
                l = midCol + 1;
            }
            else if(target < matrix[row][midCol]){
                r = midCol - 1;
            }
            else{
                return true;
            }
        }

        return false;
    }
}
