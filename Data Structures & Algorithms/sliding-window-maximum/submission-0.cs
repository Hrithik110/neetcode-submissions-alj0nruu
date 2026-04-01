public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] ans = new int[n-k+1];

        int l = 0, r = 0;
        int maxNum = int.MinValue;
        int lastFreeIdx = 0;
        while(r<n){

            maxNum = Math.Max(maxNum, nums[r]);

            if(r-l+1 == k){
                ans[lastFreeIdx] = maxNum;
                lastFreeIdx++;
                l++;
                maxNum = int.MinValue;

                int i = l;
                while(i<=r){
                    maxNum = Math.Max(nums[i], maxNum);
                    i++;
                }
            }
            r++;
        }

        return ans;
    }
}
