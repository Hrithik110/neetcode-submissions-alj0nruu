class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        left_product = 1
        right_product = 1

        res = [ 1 for i in range(len(nums))]

        for i, num in enumerate(nums):
            res[i] = left_product
            left_product *= num
        
        #res --> [1, 1, 2, 8]

        for i in range(len(nums) - 1, -1, -1):
            res[i]*= right_product
            right_product *= nums[i]
        
        #res --> [48,24,12,8]

        return res