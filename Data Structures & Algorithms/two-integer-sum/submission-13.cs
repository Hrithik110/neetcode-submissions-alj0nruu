public class Solution {
    public int[] TwoSum(int[] nums, int target) {

         Dictionary<int, int> indexMap = new Dictionary<int, int>();

        for(int idx = 0; idx<nums.Length; idx++){
            int num = nums[idx];

            if(indexMap.ContainsKey(target - num)){
                return new int[] {indexMap[target-num], idx};
            }

            indexMap[num] = idx;
        }

        return Array.Empty<int>();
    }
}
