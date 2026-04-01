public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] originalNums = (int[])nums.Clone();
        Array.Sort(nums);

        int l = 0, r = nums.Length - 1;

        while (l < r) {
            int sum = nums[l] + nums[r];

            if (sum == target) {
                int low = Array.IndexOf(originalNums, nums[l]);
                int high = nums[l] == nums[r] 
                    ? Array.IndexOf(originalNums, nums[r], low + 1) 
                    : Array.IndexOf(originalNums, nums[r]);

                return new int[] { Math.Min(low, high), Math.Max(low, high) };
            }
            else if (sum < target) {
                l++;
            }
            else {
                r--;
            }
        }

        return Array.Empty<int>();
    }
}
