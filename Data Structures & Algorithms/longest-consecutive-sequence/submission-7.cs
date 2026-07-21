public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int longestConsecutive = 0;
        for(int i = 0; i<nums.Length; i++){
            if(!set.Contains(nums[i] - 1)){
                int n = nums[i];

                int count = 0;

                while(set.Contains(n)){
                    n++;
                    count++;
                }

                longestConsecutive = Math.Max(longestConsecutive, count);
            }
        }

        return longestConsecutive;
    }
}
