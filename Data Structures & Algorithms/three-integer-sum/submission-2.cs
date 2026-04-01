public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var res = new List<List<int>>();

        for(int i = 0; i<nums.Length-2; i++){
            if(i>0 && nums[i]==nums[i-1]) continue;

            int num = nums[i];
            int l = i+1, r = nums.Length - 1;

            while(l<r){
                int sum = num + nums[l] + nums[r];

                if(sum == 0){
                    res.Add(new List<int>{num, nums[l], nums[r]});

                    while(l<r && nums[l] == nums[l+1]) l++;
                    while(l<r && nums[r-1] == nums[r]) r--;
                    l++;
                    r--;
                }
                else if(sum<0) l++;
                else r--;
            }
        }
        return res;
    }
}
