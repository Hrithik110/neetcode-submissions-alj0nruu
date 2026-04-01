public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);

        int l = 0, r = 1;
        while(r<nums.Length){
            if(nums[r]==nums[l]) return nums[r];

            l++;
            r++;
        }
        return -1;
    }
}
