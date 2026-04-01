public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;

        int l = 0, r = nums.Length - 1;

        while(l<=r){
            int mid = l + (r-l)/2;

            //right sorted

            if(nums[mid]<= nums[r]){
                min = Math.Min(nums[mid], min);
                r = mid - 1;
            }
            // left sorted
            else{
                min = Math.Min(nums[l], min);
                l = mid + 1;
            }
        }

        return min;
    }
}
