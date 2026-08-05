from queue import PriorityQueue
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        pq = PriorityQueue()

        freq = {}
        result = []
        for num in nums:
            if num in freq:
                freq[num] += 1
            else:
                freq[num] = 1
        

        for key, values in freq.items():
            pq.put((-values, key))
        
        count = 0
        while count<k:
            priority, num = pq.get()
            result.append(num)
            count+=1
        
        return result
        
        