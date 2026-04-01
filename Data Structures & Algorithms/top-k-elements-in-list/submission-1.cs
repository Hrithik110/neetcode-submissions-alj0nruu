public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> freqMap = new Dictionary<int, int>();

        for(int i = 0; i<nums.Length; i++){
            freqMap[nums[i]] = freqMap.ContainsKey(nums[i]) ? freqMap[nums[i]]+1 : 1;
        }

         var result = freqMap
                        .OrderByDescending(x => x.Value)
                        .Take(k)
                        .Select(x => x.Key)
                        .ToArray();

        return result;
    }
}
