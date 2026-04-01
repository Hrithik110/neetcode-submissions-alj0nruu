public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        for(int i = 0; i<nums.Length; i++){
            set.Add(nums[i]);
        }
        int longestSeq = 0;
        foreach(int num in set){
            if(!set.Contains(num-1)){
                int currentNum = num;
                int count = 1;
                while(set.Contains(currentNum + 1)){
                    count++;
                    currentNum++;
                }

                longestSeq = Math.Max(longestSeq, count);
            }
        }

        return longestSeq;
    }

}
