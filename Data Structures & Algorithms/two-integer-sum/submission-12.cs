public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (indexMap.ContainsKey(complement)) {
                return new int[] { indexMap[complement], i };
            }

            indexMap[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
