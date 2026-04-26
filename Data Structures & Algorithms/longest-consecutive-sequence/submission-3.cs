public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();

        foreach(int num in nums){
            set.Add(num);
        }

        int longestSeq = 0;

        for(int i = 0; i<nums.Length; i++){
            if(!set.Contains(nums[i] - 1)){
                int count = 0;
                int num = nums[i];
                while(set.Contains(num)){
                    count++;
                    num++;
                }

                longestSeq = Math.Max(longestSeq, count);
            }
        }

        return longestSeq;
    }
}
