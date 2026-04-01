public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        

        for(int i = 0; i<m; i++){
            int l = 0, r = n-1;
            while(l<=r){
                int mid = l + (r-l)/2;

                if(matrix[i][mid] == target) return true;
                else if(matrix[i][mid] > target) r--;
                else l++;
            }
            
        }
        return false;
    }
}
