class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        nums_set = set(nums)

        longest_consecutive = 0

        for i in range(len(nums)):
            num = nums[i]
            if num - 1 not in nums_set:
                current = num
                count = 0
                while current in nums_set:
                    current += 1
                    count += 1
                longest_consecutive = max(longest_consecutive, count)
        
        return longest_consecutive
        