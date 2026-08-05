class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq = [[] for i in range(len(nums) + 1)]
        count = {}
        result = []
        for num in nums:
            count[num] = count.get(num, 0) + 1
        
        for key, values in count.items():
            freq[values].append(key)
        
        for i in range(len(freq)-1, 0, -1):
            for n in freq[i]:
                result.append(n)
                if(len(result) == k):
                    return result
        
