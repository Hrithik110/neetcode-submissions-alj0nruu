public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;

        int l = 0, r = n-1;

        int result = int.MaxValue;

        while(l<=r){
            int mid = l + (r-l)/2;

            //leftSorted
            if(nums[l] <= nums[mid]){
                result = Math.Min(result, nums[l]);
                l = mid + 1;
            }
            //rightSorted
            else{
                result = Math.Min(result, nums[mid]);
                r = mid - 1;
            }
        }
        return result;
    }
}
