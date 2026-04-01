public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length-1;

        while(l<r){
            int sum = numbers[l] + numbers[r];

            if(sum == target){
                // int idx1 = Array.IndexOf(0, numbers[l]);
                // int idx2 = Array.IndexOf(l+1, numbers[r] );

                return new int[]{l+1, r+1};
            }
            else if(sum<target){
                l++;
            }
            else{
                r--;
            }
        }
        return Array.Empty<int>();
    }
}
