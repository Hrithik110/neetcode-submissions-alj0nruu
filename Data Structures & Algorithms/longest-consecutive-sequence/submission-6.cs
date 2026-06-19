public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numsSet = new HashSet<int>(nums);

        int longestConsSeq = 0;
        for(int i = 0; i<nums.Length; i++){
            if(!numsSet.Contains(nums[i]-1)){
                int num = nums[i];

                int count = 0;

                while(numsSet.Contains(num)){
                    count++;
                    num++;
                }

                longestConsSeq = Math.Max(longestConsSeq, count);
            }
        }
        return longestConsSeq;
    }
}
