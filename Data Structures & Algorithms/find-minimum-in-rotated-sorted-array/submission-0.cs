public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;

        int l = 0, r = nums.Length - 1;

        while(l<=r){
            int mid = (l + (r-l)/2);

            min = Math.Min(nums[mid], min);
            
            if(nums[r]>=nums[mid]){
                min = Math.Min(nums[mid], min);
                r = mid - 1;
            }
            else{
                min = Math.Min(nums[l], min);
                l = mid + 1;
            }
        }
        return min;
    }
}
