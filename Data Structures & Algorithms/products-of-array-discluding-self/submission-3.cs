public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int rightProduct = 1;
        int leftProduct = 1;

        int[] res = new int[nums.Length];

        for(int i = 0; i<nums.Length; i++){
            res[i] = leftProduct;

            leftProduct*=nums[i];
        }

        for(int i = nums.Length-1; i>=0; i--){
            res[i]*=rightProduct;

            rightProduct*=nums[i];
        }

        return res;
    }
}
