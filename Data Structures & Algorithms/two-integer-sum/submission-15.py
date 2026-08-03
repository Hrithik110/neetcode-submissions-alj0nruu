class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dict = {}

        
        for i in range(len(nums)):
            num = nums[i]
            complement = target - nums[i]
            if complement in dict:
                return [min(i, dict[complement]), max(i, dict[complement])]
            dict[num] = i

        return []

        