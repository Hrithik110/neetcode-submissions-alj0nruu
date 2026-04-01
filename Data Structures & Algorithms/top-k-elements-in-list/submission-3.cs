public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var freqMap = new Dictionary<int, int>();

        for(int i = 0; i<nums.Length; i++){
            freqMap[nums[i]] = freqMap.GetValueOrDefault(nums[i], 0)+1;
        }

        return freqMap.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
    }
}
