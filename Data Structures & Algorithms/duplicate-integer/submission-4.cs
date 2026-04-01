public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();

        for(int i = 0; i<nums.Length; i++){
            numSet.Add(nums[i]);
        }

        return numSet.Count != nums.Length;
    }
}