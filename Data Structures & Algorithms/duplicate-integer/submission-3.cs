public class Solution {
    public bool hasDuplicate(int[] nums) {
        
       return nums.Length != nums.Distinct().Count();
    }
}