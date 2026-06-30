public class Solution {
    public int FindMin(int[] nums) {
        
        int l = 0, r = nums.Length - 1;

        int min = int.MaxValue;

        while(r>=l){
            int mid = l + (r-l)/2;

            //left side sorted
            if(nums[mid] >= nums[l]){
               min = Math.Min(nums[l], min);
               l = mid + 1;
            }
            //right side sorted
            else{
                min = Math.Min(nums[mid], min);
                r = mid - 1;
            }
        }

        return min;
    }
}
