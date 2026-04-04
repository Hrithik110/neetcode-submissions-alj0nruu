public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach(int num in nums){
            set.Add(num);
        }

        int longestSeq = 0;

        foreach(int num in nums){
            if(!set.Contains(num-1)){
                int count = 0;

                int curr = num;

                while(set.Contains(curr)){
                    count++;
                    curr++;
                }

                longestSeq = Math.Max(count, longestSeq);
            }
        }

        return longestSeq;
    }
}
