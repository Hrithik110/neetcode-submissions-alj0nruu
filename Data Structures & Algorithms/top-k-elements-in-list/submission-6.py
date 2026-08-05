import heapq
from collections import Counter
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq = Counter(nums)

        result = []

        pq = [(-count, num) for num, count in freq.items()]

        heapq.heapify(pq)

        for _ in range(k):
            count, num = heapq.heappop(pq)
            result.append(num)
        return result
        
        