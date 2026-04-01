public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        Dictionary<int, bool> numsMap = new Dictionary<int, bool>();


        for( int i = 0; i< nums.Length; i++){
            if(numsMap.ContainsKey(nums[i])) {
                return true;
            }

            numsMap[nums[i]] = true;
        }

        return false;
    }
}