public class Solution {
    public int Search(int[] nums, int target) {

        int n = nums.Length;
        int l = 0, r = n - 1;


        while(l<=r){
            int mid = l + (r-l)/2;

            if(nums[mid] == target){
                return mid;
            }
            //leftSorted
            else if(nums[l] <= nums[mid]){
                if(nums[l]<= target && nums[mid]>=target){
                    r = mid - 1;
                }
                else{
                    l = mid + 1;
                }
            }
            //right storted
            else{
                if(nums[mid] <= target && nums[r] >=target){
                    l = mid + 1;
                }
                else{
                    r = mid - 1;
                }
            }
        }

        return -1;
    }
}
